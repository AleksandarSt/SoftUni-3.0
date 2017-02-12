using System;
using Photography.Data;
using AutoMapper;
using Photography.Dtos;
using Photography.Models;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Photography.ImportJson
{
    class Startup
    {
        private static string LensesPath = "../../../datasets/lenses.json";
        private static string CamerasPath = "../../../datasets/cameras.json";
        private static string PhotographersPath = "../../../datasets/photographers.json";
        private static string Error = "Error. Invalid data provided";

        static void Main()
        {
            UnitOfWork unit = new UnitOfWork();
            ConfigureMapping(unit);
            ImportLenses(unit);
            ImportCameras(unit);
            ImportPhotographers(unit);

        }

        private static void ImportPhotographers(UnitOfWork unit)
        {
            string json = File.ReadAllText(PhotographersPath);
            IEnumerable<PhotographerDto> phographerDtos = JsonConvert.DeserializeObject<IEnumerable<PhotographerDto>>(json);

            foreach (var phographerDto in phographerDtos)
            {
                string pattern = @"\+[0-9]{1,3}\/[0-9]{8,10}";
                Regex regex = new Regex(pattern);
                bool isPhoneValid = regex.IsMatch(phographerDto.Phone);

                if (phographerDto.FirstName == null || phographerDto.LastName == null||!isPhoneValid)
                {
                    Console.WriteLine(Error);
                    continue;
                }

                Photographer photographer = Mapper.Map<Photographer>(phographerDto);

                //todo logic for random cameras and lenses

                unit.Photographers.Add(photographer);
                unit.Commit();

                Console.WriteLine($"Successfully imported {phographerDto.FirstName} {phographerDto.LastName} | Lenses: {phographerDto.Lenses}");
            }
        }

        private static void ImportCameras(UnitOfWork unit)
        {
            string json = File.ReadAllText(CamerasPath);
            IEnumerable<CameraDto> cameraDtos = JsonConvert.DeserializeObject<IEnumerable<CameraDto>>(json);

            foreach (var cameraDto in cameraDtos)
            {
                if (cameraDto.Type == null || cameraDto.Make == null || cameraDto.Model == null || cameraDto.MinISO == 0)
                {
                    Console.WriteLine(Error);
                    continue;
                }

                if (cameraDto.Type == "DSLR")
                {
                    DSLRCamera camera = Mapper.Map<DSLRCamera>(cameraDto);

                    unit.Cameras.Add(camera);
                    unit.Commit();
                }
                else
                {
                    MirrorlessCamera camera = Mapper.Map<MirrorlessCamera>(cameraDto);

                    unit.Cameras.Add(camera);
                    unit.Commit();
                }
                Console.WriteLine($"Successfully imported {cameraDto.Type} {cameraDto.Make} {cameraDto.Model}");
            }
        }

        private static void ImportLenses(UnitOfWork unit)
        {
            string json = File.ReadAllText(LensesPath);
            IEnumerable<LensDto> lenseDtos = JsonConvert.DeserializeObject<IEnumerable<LensDto>>(json);

            foreach (var lenseDto in lenseDtos)
            {
                Lens lense = Mapper.Map<Lens>(lenseDto);

                unit.Lenses.Add(lense);
                unit.Commit();
                Console.WriteLine($"Successfully imported {lense.Make} {lense.FocalLength}mm f{lense.MaxAperture:F1}");
            }
        }

        private static void ConfigureMapping(UnitOfWork unit)
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<LensDto, Lens>();

                config.CreateMap<CameraDto, Camera>()
                .Include<CameraDto, DSLRCamera>()
                .Include<CameraDto, MirrorlessCamera>();

                config.CreateMap<CameraDto, DSLRCamera>();

                config.CreateMap<CameraDto, MirrorlessCamera>();

                config.CreateMap<PhotographerDto, Photographer>();
            });
        }
    }
}
