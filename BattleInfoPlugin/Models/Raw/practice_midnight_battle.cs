﻿namespace BattleInfoPlugin.Models.Raw
{
    /// <summary>
    /// 演習-夜戦
    /// </summary>
    public class practice_midnight_battle : ICommonBattleMembers
    {
        public int api_deck_id { get; set; }
        public int[] api_nowhps { get; set; }
        public int[] api_ship_ke { get; set; }
        public int[] api_ship_lv { get; set; }
        public int[] api_maxhps { get; set; }
        public int[][] api_eSlot { get; set; }
        public int[][] api_eKyouka { get; set; }
        public int[][] api_fParam { get; set; }
        public int[][] api_eParam { get; set; }
        public int[] api_touch_plane { get; set; }
        public int[] api_flare_pos { get; set; }
        public Midnight_Hougeki api_hougeki { get; set; }
    }
}
