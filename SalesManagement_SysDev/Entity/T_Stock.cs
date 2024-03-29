﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class T_Stock
    {
        [Key]
        public int StID { get; set; }           //在庫ID
        public int PrID { get; set; }           //商品ID
        public int StQuantity { get; set; }     //在庫数
        public int StFlag { get; set; }         //在庫管理フラグ
        public int StState { get; set; }         //在庫状況
        public string StHidden { get; set; }            //非表示理由

        public virtual M_Product M_Product { get; set; }
    }
}
