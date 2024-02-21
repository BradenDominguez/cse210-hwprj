using System;
using System.Collections.Generic;
using System.Linq;
class Ghosts
{
    private Dictionary<string, List<List<string>>> _ghosts;
    public Ghosts(){
        Dictionary<string, List<List<string>>> ghosts = new Dictionary<string, List<List<string>>>();
        string key;
        // Banshee
        key = "banshee";
        ghosts[key] = new List<List<string>>();
        List<string> BansheeEvidence = new List<string> {"Ghost Orbs", "UV", "DOTS", "None"};
        ghosts[key].Add(BansheeEvidence);
        List<string> BansheeSanityLevel = new List<string> {"87", "12-87"};
        ghosts[key].Add(BansheeSanityLevel);
        List<string> BansheeSpeed = new List<string> {"1.7", "2.5", "1.7-2.5"};
        ghosts[key].Add(BansheeSpeed);
        List<string> BansheeTrait = new List<string> {"Hunt", "Roam", "Auditory", "Sanity", "Interaction"};
        ghosts[key].Add(BansheeTrait);
        List<string> BansheeTraits = new List<string> {"hunts based on target's sanity", "roams to where the target is", "makes a unique sound in the microphone", "drains the target's sanity more than normal", "is more likely to perform a singing ghost event"};
        ghosts[key].Add(BansheeTraits);
        // Demon
        key = "demon";
        ghosts[key] = new List<List<string>>();
        List<string> DemonEvidence = new List<string> {"Freezing", "UV", "Ghost writing", "None"};
        ghosts[key].Add(DemonEvidence);
        List<string> DemonSanityLevel = new List<string> {"100", "70/100"};
        ghosts[key].Add(DemonSanityLevel);
        List<string> DemonSpeed = new List<string> {"1.7", "2.5", "1.7-2.5"};
        ghosts[key].Add(DemonSpeed);
        List<string> DemonTrait = new List<string> {"Hunt", "Prevention", "Sanity"};
        ghosts[key].Add(DemonTrait);
        List<string> DemonTraits = new List<string> {"hunts very often", "is extra weak to the crucifix", "can ignore your sanity"};
        ghosts[key].Add(DemonTraits);
        // Deogen
        key = "deogen";
        ghosts[key] = new List<List<string>>();
        List<string> DeogenEvidence = new List<string> {"Spirit Box", "DOTS", "Ghost writing", "Spirit Box"};
        ghosts[key].Add(DeogenEvidence);
        List<string> DeogenSanityLevel = new List<string> {"40", "40"};
        ghosts[key].Add(DeogenSanityLevel);
        List<string> DeogenSpeed = new List<string> {"0.4", "3", "0.4-3"};
        ghosts[key].Add(DeogenSpeed);
        List<string> DeogenTrait = new List<string> {"Roam", "Auditory", "Speed", "Visual"};
        ghosts[key].Add(DeogenTrait);
        List<string> DeogenTraits = new List<string> {"can always see you", "has a unique sound in the Spirit Box", "is slower the closer it is to you", "is easier to see than most ghosts"};
        ghosts[key].Add(DeogenTraits);
        // Goryo
        key = "goryo";
        ghosts[key] = new List<List<string>>();
        List<string> GoryoEvidence = new List<string> {"Spirit Box", "DOTS", "EMF", "DOTS"};
        ghosts[key].Add(GoryoEvidence);
        List<string> GoryoSanityLevel = new List<string> {"50", "50"};
        ghosts[key].Add(GoryoSanityLevel);
        List<string> GoryoSpeed = new List<string> {"1.7", "2.5", "1.7-2.5"};
        ghosts[key].Add(GoryoSpeed);
        List<string> GoryoTrait = new List<string> {"Roam", "Social", "Visual", "Interaction"};
        ghosts[key].Add(GoryoTrait);
        List<string> GoryoTraits = new List<string> {"roams less than most ghosts", "won't appear on DOTS if you're in the room", "can only be seen in DOTS through a camera", "can't change favorite rooms"};
        ghosts[key].Add(GoryoTraits);
        // Hantu
        key = "hantu";
        ghosts[key] = new List<List<string>>();
        List<string> HantuEvidence = new List<string> {"Ghost Orbs", "Freezing", "UV", "Freezing"};
        ghosts[key].Add(HantuEvidence);
        List<string> HantuSanityLevel = new List<string> {"50", "50"};
        ghosts[key].Add(HantuSanityLevel);
        List<string> HantuSpeed = new List<string> {"1.4", "2.7", "1.4-2.7"};
        ghosts[key].Add(HantuSpeed);
        List<string> HantuTrait = new List<string> {"Speed", "Interaction", "Visual"};
        ghosts[key].Add(HantuTrait);
        List<string> HantuTraits = new List<string> {"is faster in the cold", "can't turn on the fuse box, and will often turn it off", "sometimes has visible breath"};
        ghosts[key].Add(HantuTraits);
        // Jinn
        key = "jinn";
        ghosts[key] = new List<List<string>>();
        List<string> JinnEvidence = new List<string> {"EMF", "Freezing", "UV", "None"};
        ghosts[key].Add(JinnEvidence);
        List<string> JinnSanityLevel = new List<string> {"50", "50"};
        ghosts[key].Add(JinnSanityLevel);
        List<string> JinnSpeed = new List<string> {"1.7", "2.5", "1.7/2.5"};
        ghosts[key].Add(JinnSpeed);
        List<string> JinnTrait = new List<string> {"Speed", "Interaction", "Sanity", "Prevention"};
        ghosts[key].Add(JinnTrait);
        List<string> JinnTraits = new List<string> {"is faster if the fuse box is on", "can't turn off the fusebox", "siphons sanity through the fuse box", "can't use it's abilities without the fuse box"};
        ghosts[key].Add(JinnTraits);
        // Mare
        key = "mare";
        ghosts[key] = new List<List<string>>();
        List<string> MareEvidence = new List<string> {"Ghost Orbs", "Spirit Box", "Ghost Writing", "None"};
        ghosts[key].Add(MareEvidence);
        List<string> MareSanityLevel = new List<string> {"60", "40/60"};
        ghosts[key].Add(MareSanityLevel);
        List<string> MareSpeed = new List<string> {"1.7", "2.5", "1.7-2.5"};
        ghosts[key].Add(MareSpeed);
        List<string> MareTrait = new List<string> {"Hunt", "Interaction", "Roam", "Prevention"};
        ghosts[key].Add(MareTrait);
        List<string> MareTraits = new List<string> {"hunts more often in the dark", "breaks lights more often", "roams away from lights", "hunts less often in the light"};
        ghosts[key].Add(MareTraits);
        // Moroi
        key = "moroi";
        ghosts[key] = new List<List<string>>();
        List<string> MoroiEvidence = new List<string> {"Freezing", "Spirit Box", "Ghost Writing", "Spirit Box"};
        ghosts[key].Add(MoroiEvidence);
        List<string> MoroiSanityLevel = new List<string> {"50", "50"};
        ghosts[key].Add(MoroiSanityLevel);
        List<string> MoroiSpeed = new List<string> {"1.5", "3.71", "1.5-2.25-3.71"};
        ghosts[key].Add(MoroiSpeed);
        List<string> MoroiTrait = new List<string> {"Sanity", "Speed", "Prevention"};
        ghosts[key].Add(MoroiTrait);
        List<string> MoroiTraits = new List<string> {"can drain your sanity if you hear it", "is faster when your sanity is lower", "is blinded longer from incense"};
        ghosts[key].Add(MoroiTraits);
        // Myling
        key = "myling";
        ghosts[key] = new List<List<string>>();
        List<string> MylingEvidence = new List<string> {"EMF", "UV", "Ghost Writing", "None"};
        ghosts[key].Add(MylingEvidence);
        List<string> MylingSanityLevel = new List<string> {"50", "50"};
        ghosts[key].Add(MylingSanityLevel);
        List<string> MylingSpeed = new List<string> {"1.7", "2.5", "1.7-2.5"};
        ghosts[key].Add(MylingSpeed);
        List<string> MylingTrait = new List<string> {"Auditory", "Interaction"};
        ghosts[key].Add(MylingTrait);
        List<string> MylingTraits = new List<string> {"becomes almost completely silent while hunting", "is more likely to make paranormal sounds"};
        ghosts[key].Add(MylingTraits);
        // Obake
        key = "obake";
        ghosts[key] = new List<List<string>>();
        List<string> ObakeEvidence = new List<string> {"EMF", "UV", "Ghost Orbs", "UV"};
        ghosts[key].Add(ObakeEvidence);
        List<string> ObakeSanityLevel = new List<string> {"50", "50"};
        ghosts[key].Add(ObakeSanityLevel);
        List<string> ObakeSpeed = new List<string> {"1.7", "2.5", "1.7-2.5"};
        ghosts[key].Add(ObakeSpeed);
        List<string> ObakeTrait = new List<string> {"Visual", "Interaction"};
        ghosts[key].Add(ObakeTrait);
        List<string> ObakeTraits = new List<string> {"sometimes changes form", "has a chance to leave the wrong number of fingerprints"};
        ghosts[key].Add(ObakeTraits);
        // Oni
        key = "oni";
        ghosts[key] = new List<List<string>>();
        List<string> OniEvidence = new List<string> {"EMF", "Freezing", "DOTS", "None"};
        ghosts[key].Add(OniEvidence);
        List<string> OniSanityLevel = new List<string> {"50", "50"};
        ghosts[key].Add(OniSanityLevel);
        List<string> OniSpeed = new List<string> {"1.7", "2.5", "1.7-2.5"};
        ghosts[key].Add(OniSpeed);
        List<string> OniTrait = new List<string> {"Visual", "Interaction", "Sanity", "Social"};
        ghosts[key].Add(OniTrait);
        List<string> OniTraits = new List<string> {"is easier to see than most ghosts", "can't produce an airball", "drains more sanity than normal", "is more active with more people"};
        ghosts[key].Add(OniTraits);
        // Onryo
        key = "onryo";
        ghosts[key] = new List<List<string>>();
        List<string> OnryoEvidence = new List<string> {"Ghost Orbs", "Freezing", "Spirit Box", "None"};
        ghosts[key].Add(OnryoEvidence);
        List<string> OnryoSanityLevel = new List<string> {"100", "60/100"};
        ghosts[key].Add(OnryoSanityLevel);
        List<string> OnryoSpeed = new List<string> {"1.7", "2.5", "1.7-2.5"};
        ghosts[key].Add(OnryoSpeed);
        List<string> OnryoTrait = new List<string> {"Prevention", "Interaction", "Hunt"};
        ghosts[key].Add(OnryoTrait);
        List<string> OnryoTraits = new List<string> {"can't hunt around fire", "blows out candles faster the more times it has killed", "hunts more often after blowing out candles"};
        ghosts[key].Add(OnryoTraits);
        // Phantom
        key = "phantom";
        ghosts[key] = new List<List<string>>();
        List<string> PhantomEvidence = new List<string> {"DOTS", "Freezing", "Spirit Box", "None"};
        ghosts[key].Add(PhantomEvidence);
        List<string> PhantomSanityLevel = new List<string> {"50", "50"};
        ghosts[key].Add(PhantomSanityLevel);
        List<string> PhantomSpeed = new List<string> {"1.7", "2.5", "1.7-2.5"};
        ghosts[key].Add(PhantomSpeed);
        List<string> PhantomTrait = new List<string> {"Sanity", "Visual", "Interaction", "Roam"};
        ghosts[key].Add(PhantomTrait);
        List<string> PhantomTraits = new List<string> {"drains your sanity faster if you look at it", "is harder to see", "suddenly disappears if you take a picture of it", "randomly roams to a random player"};
        ghosts[key].Add(PhantomTraits);
        // Poltergeist
        key = "poltergeist";
        ghosts[key] = new List<List<string>>();
        List<string> PoltergeistEvidence = new List<string> {"UV", "Ghost Writing", "Spirit Box", "None"};
        ghosts[key].Add(PoltergeistEvidence);
        List<string> PoltergeistSanityLevel = new List<string> {"50", "50"};
        ghosts[key].Add(PoltergeistSanityLevel);
        List<string> PoltergeistSpeed = new List<string> {"1.7", "2.5", "1.7-2.5"};
        ghosts[key].Add(PoltergeistSpeed);
        List<string> PoltergeistTrait = new List<string> {"Sanity", "Prevention", "Interaction", "Interaction"};
        ghosts[key].Add(PoltergeistTrait);
        List<string> PoltergeistTraits = new List<string> {"drains sanity more when it throws objects", "can't use it's abilities if there are no objects", "can throw multiple objects at once", "can throw objects farther"};
        ghosts[key].Add(PoltergeistTraits);
        // Raiju
        key = "raiju";
        ghosts[key] = new List<List<string>>();
        List<string> RaijuEvidence = new List<string> {"EMF", "DOTS", "Ghost Orbs", "None"};
        ghosts[key].Add(RaijuEvidence);
        List<string> RaijuSanityLevel = new List<string> {"65", "50/65"};
        ghosts[key].Add(RaijuSanityLevel);
        List<string> RaijuSpeed = new List<string> {"1.7", "2.5", "1.7-2.5"};
        ghosts[key].Add(RaijuSpeed);
        List<string> RaijuTrait = new List<string> {"Hunt", "Speed", "Prevention", "Interaction"};
        ghosts[key].Add(RaijuTrait);
        List<string> RaijuTraits = new List<string> {"hunts more often around electronics", "is faster around electronics", "can't use it's abilities without electronics", "interferes with electronics from a wider range"};
        ghosts[key].Add(RaijuTraits);
        // Revenant
        key = "revenant";
        ghosts[key] = new List<List<string>>();
        List<string> RevenantEvidence = new List<string> {"Freezing", "Ghost Writing", "Ghost Orbs", "None"};
        ghosts[key].Add(RevenantEvidence);
        List<string> RevenantSanityLevel = new List<string> {"50", "50"};
        ghosts[key].Add(RevenantSanityLevel);
        List<string> RevenantSpeed = new List<string> {"1", "3", "1/3"};
        ghosts[key].Add(RevenantSpeed);
        List<string> RevenantTrait = new List<string> {"Roam", "Speed"};
        ghosts[key].Add(RevenantTrait);
        List<string> RevenantTraits = new List<string> {"doesn't roam often, and is slow", "sprints if it detects a player"};
        ghosts[key].Add(RevenantTraits);
        // Shade
        key = "shade";
        ghosts[key] = new List<List<string>>();
        List<string> ShadeEvidence = new List<string> {"Freezing", "Ghost Writing", "EMF", "None"};
        ghosts[key].Add(ShadeEvidence);
        List<string> ShadeSanityLevel = new List<string> {"35", "35"};
        ghosts[key].Add(ShadeSanityLevel);
        List<string> ShadeSpeed = new List<string> {"1.7", "2.5", "1.7-2.5"};
        ghosts[key].Add(ShadeSpeed);
        List<string> ShadeTrait = new List<string> {"Prevention", "Social", "Interaction"};
        ghosts[key].Add(ShadeTrait);
        List<string> ShadeTraits = new List<string> {"can't hunt nearby players", "won't interact as often around players", "is more likely to produce the shadow form ghost event"};
        ghosts[key].Add(ShadeTraits);
        // Spirit
        key = "spirit";
        ghosts[key] = new List<List<string>>();
        List<string> SpiritEvidence = new List<string> {"Spirit Box", "Ghost Writing", "EMF", "None"};
        ghosts[key].Add(SpiritEvidence);
        List<string> SpiritSanityLevel = new List<string> {"50", "50"};
        ghosts[key].Add(SpiritSanityLevel);
        List<string> SpiritSpeed = new List<string> {"1.7", "2.5", "1.7-2.5"};
        ghosts[key].Add(SpiritSpeed);
        List<string> SpiritTrait = new List<string> {"Prevention", "Interaction"};
        ghosts[key].Add(SpiritTrait);
        List<string> SpiritTraits = new List<string> {"incense prevents hunts for longer", "has no preferences"};
        ghosts[key].Add(SpiritTraits);
        // Thaye
        key = "thaye";
        ghosts[key] = new List<List<string>>();
        List<string> ThayeEvidence = new List<string> {"Ghost Orbs", "Ghost Writing", "DOTS", "None"};
        ghosts[key].Add(ThayeEvidence);
        List<string> ThayeSanityLevel = new List<string> {"75", "15-75"};
        ghosts[key].Add(ThayeSanityLevel);
        List<string> ThayeSpeed = new List<string> {"1", "2.75", "1-2.75"};
        ghosts[key].Add(ThayeSpeed);
        List<string> ThayeTrait = new List<string> {"Interaction", "Hunt", "Speed", "Social"};
        ghosts[key].Add(ThayeTrait);
        List<string> ThayeTraits = new List<string> {"interacts often, but gets slower over time", "hunts often, but less over time", "starts out fast, but gets slower over time", "gets slower the more people are around it"};
        ghosts[key].Add(ThayeTraits);
        // Mimic
        key = "mimic";
        ghosts[key] = new List<List<string>>();
        List<string> MimicEvidence = new List<string> {"Spirit Box", "Freezing", "UV", "Ghost Orbs"};
        ghosts[key].Add(MimicEvidence);
        List<string> MimicSanityLevel = new List<string> {"100", "15-85/100"};
        ghosts[key].Add(MimicSanityLevel);
        List<string> MimicSpeed = new List<string> {"0.4", "3.71", "0.4-3.71"};
        ghosts[key].Add(MimicSpeed);
        List<string> MimicTrait = new List<string> {"Interaction", "Visual"};
        ghosts[key].Add(MimicTrait);
        List<string> MimicTraits = new List<string> {"will always have ghost orbs", "can leave fingerprints on the exit door"};
        ghosts[key].Add(MimicTraits);
        // Twins
        key = "twins";
        ghosts[key] = new List<List<string>>();
        List<string> TwinsEvidence = new List<string> {"Spirit Box", "Freezing", "EMF", "None"};
        ghosts[key].Add(TwinsEvidence);
        List<string> TwinsSanityLevel = new List<string> {"50", "50"};
        ghosts[key].Add(TwinsSanityLevel);
        List<string> TwinsSpeed = new List<string> {"1.53", "2.5", "1.53/1.87-2.5"};
        ghosts[key].Add(TwinsSpeed);
        List<string> TwinsTrait = new List<string> {"Interaction", "Speed"};
        ghosts[key].Add(TwinsTrait);
        List<string> TwinsTraits = new List<string> {"can interact in two places at once", "will wither be slow or fast"};
        ghosts[key].Add(TwinsTraits);
        // Wraith
        key = "wraith";
        ghosts[key] = new List<List<string>>();
        List<string> WraithEvidence = new List<string> {"Spirit Box", "DOTS", "EMF", "None"};
        ghosts[key].Add(WraithEvidence);
        List<string> WraithSanityLevel = new List<string> {"50", "50"};
        ghosts[key].Add(WraithSanityLevel);
        List<string> WraithSpeed = new List<string> {"1.7", "2.5", "1.7-2.5"};
        ghosts[key].Add(WraithSpeed);
        List<string> WraithTrait = new List<string> {"Prevention", "Roam"};
        ghosts[key].Add(WraithTrait);
        List<string> WraithTraits = new List<string> {"won't walk on salt", "can sometimes teleport to you"};
        ghosts[key].Add(WraithTraits);
        // Yokai
        key = "yokai";
        ghosts[key] = new List<List<string>>();
        List<string> YokaiEvidence = new List<string> {"Spirit Box", "DOTS", "Ghost Orbs", "None"};
        ghosts[key].Add(YokaiEvidence);
        List<string> YokaiSanityLevel = new List<string> {"80", "50/80"};
        ghosts[key].Add(YokaiSanityLevel);
        List<string> YokaiSpeed = new List<string> {"1.7", "2.5", "1.7-2.5"};
        ghosts[key].Add(YokaiSpeed);
        List<string> YokaiTrait = new List<string> {"Hunt", "Prevention", "Social"};
        ghosts[key].Add(YokaiTrait);
        List<string> YokaiTraits = new List<string> {"hunts more often when you're talking", "can't hear very well", "is more active when you're talking nearby"};
        ghosts[key].Add(YokaiTraits);
        // Yurei
        key = "yurei";
        ghosts[key] = new List<List<string>>();
        List<string> YureiEvidence = new List<string> {"Freezing", "DOTS", "Ghost Orbs", "None"};
        ghosts[key].Add(YureiEvidence);
        List<string> YureiSanityLevel = new List<string> {"50", "50"};
        ghosts[key].Add(YureiSanityLevel);
        List<string> YureiSpeed = new List<string> {"1.7", "2.5", "1.7-2.5"};
        ghosts[key].Add(YureiSpeed);
        List<string> YureiTrait = new List<string> {"Sanity", "Prevention", "Roam", "Interaction"};
        ghosts[key].Add(YureiTrait);
        List<string> YureiTraits = new List<string> {"drains sanity using doors", "gets stuck when you use incense on it", "roams less around incense", "can slam a door shut"};
        ghosts[key].Add(YureiTraits);
        _ghosts = ghosts;
    }
    public Dictionary<string, List<List<string>>> GetGhostDict()
    {
        return _ghosts;
    }
    public void List()
    {
        Console.WriteLine("Full Ghost List:");
        foreach (string key in _ghosts.Keys)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(key);
            Console.ForegroundColor = ConsoleColor.Green;
            List<List<string>> stats = _ghosts[key];
            Console.WriteLine($"Evidences: {stats[0][0]}, {stats[0][1]}, {stats[0][2]}; Favorite Evidence: {stats[0][3]}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Max Hunt Threshold: {stats[1][0]}; Actual Hunt Threshold: {stats[1][1]}");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Min Speed: {stats[2][0]}; Max Speed: {stats[2][1]}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach(string trait in stats[3]){
                Console.Write($"{trait}, ");
            }
            Console.WriteLine("\n");
        }
    } 
    public string GetGhost()
    {
        Random random = new Random();
        List<string> keys = new List<string>(_ghosts.Keys);
        string randomKey = keys[random.Next(keys.Count)];
        return randomKey;
    }
}