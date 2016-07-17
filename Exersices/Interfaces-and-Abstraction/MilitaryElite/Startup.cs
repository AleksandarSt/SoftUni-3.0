using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using MilitaryElite.Interfaces;
using MilitaryElite.Models;

namespace MilitaryElite
{
    class Startup
    {
        static void Main()
        {
            string[] soldierInfo = Console.ReadLine().Split();
            string command = soldierInfo[0];

            Dictionary<int, ISoldier> soldiers = new Dictionary<int, ISoldier>();

            while (command != "End")
            {
                string soldierType = soldierInfo[0];
                int soldierId = int.Parse(soldierInfo[1]);
                string soldierFirstName = soldierInfo[2];
                string soldierLastName = soldierInfo[3];


                if (soldierType == "Private")
                {
                    var @private = CreatePrivate(soldierInfo, soldierId, soldierFirstName, soldierLastName, soldiers);
                    Console.WriteLine(@private);
                }
                else if (soldierType == "LeutenantGeneral")
                {
                    var leutenantGeneral = CreateLeutenantGeneral(soldierInfo, soldiers, soldierId, soldierFirstName,
                        soldierLastName);
                    Console.WriteLine(leutenantGeneral);
                }
                else if (soldierType == "Engineer")
                {
                    double soldierSalary = double.Parse(soldierInfo[4]);
                    string corps = soldierInfo[5];

                    if (corps== "Airforces"||corps== "Marines")
                    {
                        var engineer = CreateEngineer(corps, soldierInfo, soldierId, soldierFirstName, soldierLastName,
                            soldierSalary, soldiers);

                        Console.WriteLine(engineer);
                    }
                }
                else if (soldierType=="Commando")
                {
                    double soldierSalary = double.Parse(soldierInfo[4]);
                    string corps = soldierInfo[5];

                    if (corps == "Airforces" || corps == "Marines")
                    {
                        var commando = CreateCommando(corps, soldierInfo, soldierId, soldierFirstName, soldierLastName, soldierSalary, soldiers);

                        Console.WriteLine(commando);
                    }
                }
                else if (soldierType=="Spy")
                {
                    var spy = CreateSpy(soldierInfo, soldierId, soldierFirstName, soldierLastName);

                    Console.WriteLine(spy);
                }

                soldierInfo = Console.ReadLine().Split();
                command = soldierInfo[0];
            }

        }

        private static ISpy CreateSpy(string[] soldierInfo, int soldierId, string soldierFirstName, string soldierLastName)
        {
            int codeNumber = int.Parse(soldierInfo[5]);
            ISpy spy = new Spy(soldierId, soldierFirstName, soldierLastName, codeNumber);
            return spy;
        }

        private static ICommando CreateCommando(string corps, string[] soldierInfo, int soldierId, string soldierFirstName,
            string soldierLastName, double soldierSalary, Dictionary<int, ISoldier> soldiers)
        {
            CorpTypes corpType = (CorpTypes) Enum.Parse(typeof(CorpTypes), corps);
            List<Mission> missions = new List<Mission>();

            for (int i = 6; i < soldierInfo.Length; i += 2)
            {
                string codeName = soldierInfo[i];
                string missionState = soldierInfo[i + 1];

                if (missionState == "inProgress" || missionState == "finished")
                {
                    CreateMission(missionState, missions, codeName);
                }
            }

            ICommando commando = new Commando(soldierId, soldierFirstName, soldierLastName, soldierSalary,
                corpType, missions);
            soldiers.Add(soldierId, commando);
            return commando;
        }

        private static void CreateMission(string missionState, List<Mission> missions, string codeName)
        {
            MissionStates state = (MissionStates) Enum.Parse(typeof(MissionStates), missionState);

            missions.Add(new Mission(codeName, state));
        }

        private static IEngineer CreateEngineer(string corps, string[] soldierInfo, int soldierId, string soldierFirstName,
            string soldierLastName, double soldierSalary, Dictionary<int, ISoldier> soldiers)
        {
            CorpTypes corpType = (CorpTypes) Enum.Parse(typeof(CorpTypes), corps);
            var repairs = CreateRepairs(soldierInfo);

            IEngineer engineer = new Engineer(soldierId, soldierFirstName, soldierLastName, soldierSalary, corpType, repairs);
            soldiers.Add(soldierId,engineer);

            return engineer;
        }

        private static List<Repair> CreateRepairs(string[] soldierInfo)
        {
            List<Repair> repairs = new List<Repair>();

            for (int i = 6; i < soldierInfo.Length; i += 2)
            {
                string partName = soldierInfo[i];
                int repairHours = int.Parse(soldierInfo[i + 1]);

                repairs.Add(new Repair(partName, repairHours));
            }
            return repairs;
        }

        private static ILeutenantGeneral CreateLeutenantGeneral(string[] soldierInfo, Dictionary<int, ISoldier> soldiers, int soldierId,
            string soldierFirstName, string soldierLastName)
        {
            double soldierSalary = double.Parse(soldierInfo[4]);
            Dictionary<int, Private> army = new Dictionary<int, Private>();

            for (int i = 5; i < soldierInfo.Length; i++)
            {
                int privateId = int.Parse(soldierInfo[i]);

                if (soldiers.ContainsKey(privateId))
                {
                    army.Add(privateId, (Private) soldiers[privateId]);
                }
            }

            ILeutenantGeneral leutenantGeneral = new LeutenantGeneral(soldierId, soldierFirstName,
                soldierLastName, soldierSalary, army);
            soldiers.Add(soldierId, leutenantGeneral);
            return leutenantGeneral;
        }

        private static IPrivate CreatePrivate(string[] soldierInfo, int soldierId, string soldierFirstName,
            string soldierLastName, Dictionary<int, ISoldier> soldiers)
        {
            double soldierSalary = double.Parse(soldierInfo[4]);
            IPrivate @private = new Private(soldierId, soldierFirstName, soldierLastName, soldierSalary);
            soldiers.Add(soldierId, @private);
            return @private;
        }
    }
}
