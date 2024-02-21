// public class SettingsClassic : Settings{
//     public SettingsClassic(string evidence, string hunt, string speed, string trait) : base(evidence, hunt, speed, trait)
//     {

//     }
//     public override void EvidenceSetting(){
//         string valid = "false";
//         string setting;
//         do{
//         Console.WriteLine("Input a number:");
//         Console.WriteLine("3. Three Evidence");
//         Console.WriteLine("2. Two Evidence");
//         Console.WriteLine("1. One Evidence");
//         Console.WriteLine("0. Zero Evidence");
//         setting = Console.ReadLine();
//         if (setting == "3" || setting == "2"|| setting == "1"|| setting == "0"){
//             valid = "true";
//         }else{
//             Console.WriteLine("Invalid response.");
//         }
//         }while(valid == "false");
//         _evidenceSetting = setting;
//         GameClassic.setEvidence(setting);
//         }
//     public override void HuntSetting(){
//             string valid = "false";
//             string setting;
//             do{
//             Console.WriteLine("Input a number:");
//             Console.WriteLine("1. Enabled");
//             Console.WriteLine("2. Disabled");
//             setting = Console.ReadLine();
//             if (setting == "1" || setting == "2"){
//                 valid = "true";
//             }else{
//                 Console.WriteLine("Invalid response.");
//             }
//             }while(valid == "false");
//             _huntSetting = setting;
//         }
//     public override void SpeedSetting(){
//             string valid = "false";
//             string setting = "3";
//             do{
//             Console.WriteLine("Input a number:");
//             Console.WriteLine("1. Min and Max Speed Enabled");
//             Console.WriteLine("2. Min Speed Enabled");
//             Console.WriteLine("3. Max Speed Enabled");
//             Console.WriteLine("4. Both Disabled");
//             setting = Console.ReadLine();
//             if (setting == "1" || setting == "2" || setting == "3" || setting == "4"){
//                 valid = "true";
//             }else{
//                 Console.WriteLine("Invalid response.");
//             }
//             }while(valid == "false");
//             _speedSetting = setting;
//         }
//     public override void TraitSetting(){
//             string valid = "false";
//             string setting = "3";
//             do{
//             Console.WriteLine("Input a number:");
//             Console.WriteLine("4. Four traits");
//             Console.WriteLine("3. Three Traits");
//             Console.WriteLine("2. Two Traits");
//             Console.WriteLine("1. Once Traits");
//             Console.WriteLine("0. Zero Traits");
//             setting = Console.ReadLine();
//             if (setting == "1" || setting == "2" || setting == "3" || setting == "4"|| setting == "0"){
//                 valid = "true";
//             }else{
//                 Console.WriteLine("Invalid response.");
//             }
//             }while(valid == "false");
//             _traitSetting = setting;
//         }
// }