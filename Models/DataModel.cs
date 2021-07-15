using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webappPolutionIndex.model
{
    
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Root
        {
            public string hero_1_image { get; set; }
            public string hero_1_title { get; set; }

            [JsonProperty("article-info_1_byline")]
            public string ArticleInfo1Byline { get; set; }

            [JsonProperty("article-info_1_date")]
            public string ArticleInfo1Date { get; set; }

            [JsonProperty("article-info_1_category")]
            public string ArticleInfo1Category { get; set; }

            [JsonProperty("article-info_1_category_url")]
            public string ArticleInfo1CategoryUrl { get; set; }
            public string p_1_value { get; set; }
            public string total_cities_1_value { get; set; }
            public string p_2_value { get; set; }
            public string p_3_value { get; set; }
            public string p_4_value { get; set; }
            public string p_5_value { get; set; }

            [JsonProperty("compare-tabs_1_method")]
            public string CompareTabs1Method { get; set; }

            [JsonProperty("compare-tabs_1_title")]
            public string CompareTabs1Title { get; set; }

            [JsonProperty("compare-tabs_1_city_1_name")]
            public string CompareTabs1City1Name { get; set; }

            [JsonProperty("compare-tabs_1_city_1_aqi")]
            public string CompareTabs1City1Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_1_cigg")]
            public string CompareTabs1City1Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_2_name")]
            public string CompareTabs1City2Name { get; set; }

            [JsonProperty("compare-tabs_1_city_2_aqi")]
            public string CompareTabs1City2Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_2_cigg")]
            public string CompareTabs1City2Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_3_name")]
            public string CompareTabs1City3Name { get; set; }

            [JsonProperty("compare-tabs_1_city_3_aqi")]
            public string CompareTabs1City3Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_3_cigg")]
            public string CompareTabs1City3Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_4_name")]
            public string CompareTabs1City4Name { get; set; }

            [JsonProperty("compare-tabs_1_city_4_aqi")]
            public string CompareTabs1City4Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_4_cigg")]
            public string CompareTabs1City4Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_5_name")]
            public string CompareTabs1City5Name { get; set; }

            [JsonProperty("compare-tabs_1_city_5_aqi")]
            public string CompareTabs1City5Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_5_cigg")]
            public string CompareTabs1City5Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_6_name")]
            public string CompareTabs1City6Name { get; set; }

            [JsonProperty("compare-tabs_1_city_6_aqi")]
            public string CompareTabs1City6Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_6_cigg")]
            public string CompareTabs1City6Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_7_name")]
            public string CompareTabs1City7Name { get; set; }

            [JsonProperty("compare-tabs_1_city_7_aqi")]
            public string CompareTabs1City7Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_7_cigg")]
            public string CompareTabs1City7Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_8_name")]
            public string CompareTabs1City8Name { get; set; }

            [JsonProperty("compare-tabs_1_city_8_aqi")]
            public string CompareTabs1City8Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_8_cigg")]
            public string CompareTabs1City8Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_9_name")]
            public string CompareTabs1City9Name { get; set; }

            [JsonProperty("compare-tabs_1_city_9_aqi")]
            public string CompareTabs1City9Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_9_cigg")]
            public string CompareTabs1City9Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_10_name")]
            public string CompareTabs1City10Name { get; set; }

            [JsonProperty("compare-tabs_1_city_10_aqi")]
            public string CompareTabs1City10Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_10_cigg")]
            public string CompareTabs1City10Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_11_name")]
            public string CompareTabs1City11Name { get; set; }

            [JsonProperty("compare-tabs_1_city_11_aqi")]
            public string CompareTabs1City11Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_11_cigg")]
            public string CompareTabs1City11Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_12_name")]
            public string CompareTabs1City12Name { get; set; }

            [JsonProperty("compare-tabs_1_city_12_aqi")]
            public string CompareTabs1City12Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_12_cigg")]
            public string CompareTabs1City12Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_13_name")]
            public string CompareTabs1City13Name { get; set; }

            [JsonProperty("compare-tabs_1_city_13_aqi")]
            public string CompareTabs1City13Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_13_cigg")]
            public string CompareTabs1City13Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_14_name")]
            public string CompareTabs1City14Name { get; set; }

            [JsonProperty("compare-tabs_1_city_14_aqi")]
            public string CompareTabs1City14Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_14_cigg")]
            public string CompareTabs1City14Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_15_name")]
            public string CompareTabs1City15Name { get; set; }

            [JsonProperty("compare-tabs_1_city_15_aqi")]
            public string CompareTabs1City15Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_15_cigg")]
            public string CompareTabs1City15Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_16_name")]
            public string CompareTabs1City16Name { get; set; }

            [JsonProperty("compare-tabs_1_city_16_aqi")]
            public string CompareTabs1City16Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_16_cigg")]
            public string CompareTabs1City16Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_17_name")]
            public string CompareTabs1City17Name { get; set; }

            [JsonProperty("compare-tabs_1_city_17_aqi")]
            public string CompareTabs1City17Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_17_cigg")]
            public string CompareTabs1City17Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_18_name")]
            public string CompareTabs1City18Name { get; set; }

            [JsonProperty("compare-tabs_1_city_18_aqi")]
            public string CompareTabs1City18Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_18_cigg")]
            public string CompareTabs1City18Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_19_name")]
            public string CompareTabs1City19Name { get; set; }

            [JsonProperty("compare-tabs_1_city_19_aqi")]
            public string CompareTabs1City19Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_19_cigg")]
            public string CompareTabs1City19Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_20_name")]
            public string CompareTabs1City20Name { get; set; }

            [JsonProperty("compare-tabs_1_city_20_aqi")]
            public string CompareTabs1City20Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_20_cigg")]
            public string CompareTabs1City20Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_21_name")]
            public string CompareTabs1City21Name { get; set; }

            [JsonProperty("compare-tabs_1_city_21_aqi")]
            public string CompareTabs1City21Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_21_cigg")]
            public string CompareTabs1City21Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_22_name")]
            public string CompareTabs1City22Name { get; set; }

            [JsonProperty("compare-tabs_1_city_22_aqi")]
            public string CompareTabs1City22Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_22_cigg")]
            public string CompareTabs1City22Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_23_name")]
            public string CompareTabs1City23Name { get; set; }

            [JsonProperty("compare-tabs_1_city_23_aqi")]
            public string CompareTabs1City23Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_23_cigg")]
            public string CompareTabs1City23Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_24_name")]
            public string CompareTabs1City24Name { get; set; }

            [JsonProperty("compare-tabs_1_city_24_aqi")]
            public string CompareTabs1City24Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_24_cigg")]
            public string CompareTabs1City24Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_25_name")]
            public string CompareTabs1City25Name { get; set; }

            [JsonProperty("compare-tabs_1_city_25_aqi")]
            public string CompareTabs1City25Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_25_cigg")]
            public string CompareTabs1City25Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_26_name")]
            public string CompareTabs1City26Name { get; set; }

            [JsonProperty("compare-tabs_1_city_26_aqi")]
            public string CompareTabs1City26Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_26_cigg")]
            public string CompareTabs1City26Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_27_name")]
            public string CompareTabs1City27Name { get; set; }

            [JsonProperty("compare-tabs_1_city_27_aqi")]
            public string CompareTabs1City27Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_27_cigg")]
            public string CompareTabs1City27Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_28_name")]
            public string CompareTabs1City28Name { get; set; }

            [JsonProperty("compare-tabs_1_city_28_aqi")]
            public string CompareTabs1City28Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_28_cigg")]
            public string CompareTabs1City28Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_29_name")]
            public string CompareTabs1City29Name { get; set; }

            [JsonProperty("compare-tabs_1_city_29_aqi")]
            public string CompareTabs1City29Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_29_cigg")]
            public string CompareTabs1City29Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_30_name")]
            public string CompareTabs1City30Name { get; set; }

            [JsonProperty("compare-tabs_1_city_30_aqi")]
            public string CompareTabs1City30Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_30_cigg")]
            public string CompareTabs1City30Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_31_name")]
            public string CompareTabs1City31Name { get; set; }

            [JsonProperty("compare-tabs_1_city_31_aqi")]
            public string CompareTabs1City31Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_31_cigg")]
            public string CompareTabs1City31Cigg { get; set; }

            [JsonProperty("compare-tabs_1_city_32_name")]
            public string CompareTabs1City32Name { get; set; }

            [JsonProperty("compare-tabs_1_city_32_aqi")]
            public string CompareTabs1City32Aqi { get; set; }

            [JsonProperty("compare-tabs_1_city_32_cigg")]
            public string CompareTabs1City32Cigg { get; set; }
            public string p_6_value { get; set; }
            public string p_7_value { get; set; }
            public string p_8_value { get; set; }
            public string p_9_value { get; set; }
            public string p_10_value { get; set; }
        }


    }

