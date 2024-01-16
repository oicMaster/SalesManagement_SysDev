using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesManagement_SysDev
{
    class T_OperationHistory
    {

        [Key]
        public int OpID { get; set; }        //ログイン操作ID		
        public int EmID { get; set; }               //社員ID
        [MaxLength(50)]
        [Required]
        public string OpForm { get; set; }        //フォーム名
        [MaxLength(50)]
        [Required]
        public string OpButton { get; set; }        //ボタン名
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? OpTime { get; set; }  //操作時刻//	


        public virtual M_Employee M_Employee { get; set; }
    }
}
