﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ORD_SAL_v1._0
{
    //class로 바꿔야 할텐데...
    public struct characterDB
    {
        public int index;
        public string name;
        public string shortname;
        public Image img;
        public bool sel;
    }

    public class Commonamount
    {
        [JsonProperty(PropertyName = "이름")]
        public string characterName { get; set; }
        [JsonProperty(PropertyName = "루피")]
        public int Luppi { get; set; }
        [JsonProperty(PropertyName = "조로")]
        public int Zoro { get; set; }
        [JsonProperty(PropertyName = "나미")]
        public int Nami { get; set; }
        [JsonProperty(PropertyName = "우솝")]
        public int Usopp { get; set; }
        [JsonProperty(PropertyName = "상디")]
        public int Sanji { get; set; }
        [JsonProperty(PropertyName = "쵸파")]
        public int Chopper { get; set; }
        [JsonProperty(PropertyName = "버기")]
        public int Buggy { get; set; }
        [JsonProperty(PropertyName = "총병")]
        public int musketeer { get; set; }
        [JsonProperty(PropertyName = "칼병")]
        public int Swordsman { get; set; }
        [JsonProperty(PropertyName = "계")]
        public int TotalCommonamount { get; set; }
    }
    public class character_Info
    {
        public List<characterDB> chList = new List<characterDB>();
        public List<Commonamount> CommonamountList = new List<Commonamount>();


        #region 평천님이 짜준 싱글톤 모양 참고해서 다바꾸기
        private static character_Info _instance;
        private character_Info() { InitList(); }
        public static character_Info Instance => _instance ?? (_instance = new character_Info());
        #endregion
        public void InitList()
        {
            #region characterDB Init
            characterDB temp = new characterDB();
            temp.index = 1;
            temp.name = "조로초월";
            temp.img = Properties.Resources.조로;
            temp.shortname = "조로";
            temp.sel = false;
            chList.Add(temp);
            temp.index = 2;
            temp.name = "나미초월";
            temp.img = Properties.Resources.나미;
            temp.shortname = "나미";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 3;
            temp.name = "상디초월";
            temp.img = Properties.Resources.상디;
            temp.shortname = "상디";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 4;
            temp.name = "프랑키초월";
            temp.img = Properties.Resources.프랑키;
            temp.shortname = "프랑키";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 5;
            temp.name = "브룩초월";
            temp.img = Properties.Resources.브룩;
            temp.shortname = "브룩";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 6;
            temp.name = "샹크스초월";
            temp.img = Properties.Resources.샹크스;
            temp.shortname = "샹크스";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 7;
            temp.name = "검은수염초월";
            temp.img = Properties.Resources.검은수염;
            temp.shortname = "검은수염";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 8;
            temp.name = "시라호시초월";
            temp.img = Properties.Resources.시라호시;
            temp.shortname = "시라호시";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 9;
            temp.name = "아오키지초월";
            temp.img = Properties.Resources.아오키지;
            temp.shortname = "아오키지";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 10;
            temp.name = "아카이누초월";
            temp.img = Properties.Resources.아카이누;
            temp.shortname = "아카이누";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 11;
            temp.name = "키자루초월";
            temp.img = Properties.Resources.키자루;
            temp.shortname = "키자루";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 12;
            temp.name = "로우초월";
            temp.img = Properties.Resources.로우;
            temp.shortname = "로우";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 13;
            temp.name = "타시기초월";
            temp.img = Properties.Resources.타시기;
            temp.shortname = "타시기";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 14;
            temp.name = "빅맘불멸";
            temp.img = Properties.Resources.빅맘;
            temp.shortname = "빅맘";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 15;
            temp.name = "루치초월";
            temp.img = Properties.Resources.루치;
            temp.shortname = "루치";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 16;
            temp.name = "스네이크맨초월함";
            temp.img = Properties.Resources.루피;
            temp.shortname = "스네이크맨";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 17;
            temp.name = "레일리불멸";//하이브리드
            temp.img = Properties.Resources.레일리;
            temp.shortname = "레일리";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 18;
            temp.name = "흰수염불멸";//하이브리드
            temp.img = Properties.Resources.흰수염;
            temp.shortname = "흰수염";
            temp.sel = false;
            chList.Add(temp);
            temp.index = 19;
            temp.name = "센고쿠불멸";
            temp.img = Properties.Resources.센고쿠;
            temp.shortname = "센고쿠";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 20;
            temp.name = "시키불멸";
            temp.img = Properties.Resources.시키;
            temp.shortname = "시키";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 21;
            temp.name = "드래곤불멸";
            temp.img = Properties.Resources.드래곤;
            temp.shortname = "드래곤";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 22;
            temp.name = "제트불멸";
            temp.img = Properties.Resources.제파;
            temp.shortname = "제트";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 23;
            temp.name = "시노부제한됨";
            temp.img = Properties.Resources.시노부;
            temp.shortname = "시노부";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 24;
            temp.name = "에넬제한됨";
            temp.img = Properties.Resources.에넬;
            temp.shortname = "에넬";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 25;
            temp.name = "레드필드제한됨";
            temp.img = Properties.Resources.레드필드;
            temp.shortname = "레드필드";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 26;
            temp.name = "에이스영원함"; 
            temp.img = Properties.Resources.에이스;
            temp.shortname = "에이스";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 27;
            temp.name = "핸콕영원함";
            temp.img = Properties.Resources.핸콕;
            temp.shortname = "핸콕";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 28;
            temp.name = "오뎅영원함";
            temp.img = Properties.Resources.오뎅;
            temp.shortname = "오뎅";
            temp.sel = true;
            chList.Add(temp);
            temp.index = 29;
            temp.name = "미호크영원함";
            temp.img = Properties.Resources.미호크;
            temp.shortname = "미호크";
            temp.sel = true;
            chList.Add(temp);
            #endregion

        }

        public void ListCheckChange(int index, bool ch)
        {
            characterDB temp = chList[index];
            temp.sel = ch;
            chList[index] = temp;
        }
    }
}
