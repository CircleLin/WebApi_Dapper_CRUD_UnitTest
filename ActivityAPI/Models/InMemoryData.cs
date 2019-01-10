using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActivityAPI.Models
{
    /// <summary>
    /// In Memory Data
    /// </summary>
    public class InMemoryData
    {
        private static List<Models.Activity> _Activities = null;

        public static List<Models.Activity> Activities
        {
            get
            {
                #region 使用靜態屬性代替資料庫
                if (_Activities == null || _Activities.Count <= 0)
                {
                    _Activities = new List<Activity>
                    {
                        new Activity()
                        {
                            ActivityId = 1,
                            Name = "大安盃幼兒足球營",
                            ActivityDate = "2019-01-04 - 2019-01-30",
                            Desc = "奔馳在草綠的球場上，帥氣的足球球員們帶動著球，團隊憑著戰術機智衝鋒陷陣，一計黃金左腳，射門得分！從世足賽到帥氣足球明星，足球總能掀起陣陣全球風潮，足球是個訓練全身肢體協調、將團隊合作發揮的淋漓盡致的全能訓練，更棒的是年紀小小就可以培養了！帶著家中的小寶貝到專業的 ASA 運動教室，歡笑踢球、培養正確的運動知識與對運動的熱情吧！",
                            EarlyPrice = 2400,
                            Price = 3600,
                            ImgUrl = "https://s.yimg.com/ny/api/res/1.2/kXOiUS7bhDyNItjkxCt3YA--~A/YXBwaWQ9aGlnaGxhbmRlcjtzbT0xO3c9NTEwO2g9MzE5/http://media.zenfs.com/zh-Hant-TW/homerun/setn.com.tw/ab1258370294d57f1ac7d67b3e965bf0",
                            RegisterCount = 17,
                            Teacher = "熊熊教練",
                            Count = 20
                        },
                        new Activity()
                        {
                            ActivityId = 2,
                            Name = "程式冬令營【4-6年級】EV3程式冬令營",
                            ActivityDate = "2019-01-21 - 2019-01-21",
                            Desc = "讓孩子自己組裝樂高EV3機器人培養機械原理，並藉由APP INVENTOR2撰寫程式，創造一個能按孩子指令行動的機器人，發覺LEGO結合程式的樂趣！",
                            EarlyPrice = 7400,
                            Price = 8000,
                            ImgUrl = "https://az796311.vo.msecnd.net/userupload/02ffb38fb46c46e789b6f104384b394d.jpg",
                            RegisterCount = 10,
                            Teacher = "樂樂老師",
                            Count = 15
                        },
                        new Activity()
                        {
                            ActivityId = 3,
                            Name = "百老匯音樂劇兒童冬令營",
                            ActivityDate = "2019-01-21 - 2019-01-25",
                            Desc = "​一週內，唱遍百老匯各大音樂劇經典歌曲！ 唱歌X演戲Ｘ跳舞 全方位五感體驗！使用專業燈光，登上大舞台呈現！啟發團隊能力、整合能力、英語能力、提升自信、戰勝恐懼、創造巨星風範的絕佳機會！",
                            EarlyPrice = 8000,
                            Price = 9000,
                            ImgUrl = "https://az796311.vo.msecnd.net/userupload/3df7ae5b26dc4e87862c10db51d7c6da.jpg",
                            RegisterCount = 30,
                            Teacher = "Faron Swingler",
                            Count = 32
                        }
                    };
                }
                #endregion

                return Activities;
            }
        }     
        
    }
}