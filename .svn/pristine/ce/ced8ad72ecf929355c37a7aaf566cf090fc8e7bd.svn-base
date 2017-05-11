using System.Collections.Generic;

namespace Entity.System
{
    //public class PingjiaTab
    //{

    //    public int DeviceType { get; set; }
    //    public int PingjiaLevel { get; set; }
    //}

    public struct PingjiaTab<T1, T2>
    {
        public readonly T1 Item1;
        public readonly T2 Item2;

        public PingjiaTab(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }

    public class PingjiaViewConfigs
    {
        public static Dictionary<PingjiaTab<int, int>, string> PingjiaLevelViewDict = new Dictionary<PingjiaTab<int, int>, string>
        {
            {
                new PingjiaTab<int, int>(1,1),
                "ecology_lv1"
            },
            {
                new PingjiaTab<int, int>(1,2),
                "ecology_lv2"
            },
            {
                new PingjiaTab<int, int>(1,3),
                "ecology_lv3"
            },
            {
                new PingjiaTab<int, int>(1,4),
                "ecology_lv4"
            },
            {
                new PingjiaTab<int, int>(2,1),
                "BUOYECOLOGY_LV1"
            },
            {
                new PingjiaTab<int, int>(2,2),
                "BUOYECOLOGY_LV2"
            },
            {
                new PingjiaTab<int, int>(2,3),
                "BUOYECOLOGY_LV3"
            },
            {
                new PingjiaTab<int, int>(2,4),
                "BUOYECOLOGY_LV4"
            }
        };




    }
}
