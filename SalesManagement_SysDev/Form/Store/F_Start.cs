using SalesManagement_SysDev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_Start : Form
    {
        public F_Start()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
        }


        private void F_Start_Load(object sender, EventArgs e)
        {
            if (!DatabaseExists())
            {
                CleateDabase();
                InsertSampleData();
                Dispose();
            }
            else
            {
                Timer timer = new Timer();
                timer.Interval = 5000;
                timer.Tick += (s, args) =>
                {
                    timer.Stop();
                    this.Dispose();
                };
                timer.Start();
            }
        }
        private bool DatabaseExists()
        {
            try
            {
                using (var context = new SalesManagement_DevContext())
                {
                    context.Database.Connection.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CleateDabase()
        {
            //データベースの生成を行います．
            //再度実行する場合には，必ずデータベースの削除をしてから実行してください．

            SalesManagement_DevContext context = new SalesManagement_DevContext();


            List<M_Position> po = new List<M_Position>();

            {
                po.Add(new M_Position()
                {
                    PoName = "管理者",
                    PoFlag = 0,
                });
                po.Add(new M_Position()
                {
                    PoName = "営業",
                    PoFlag = 0,
                });
                po.Add(new M_Position()
                {
                    PoName = "物流",
                    PoFlag = 0,
                });
                context.M_Positions.AddRange(po);
                context.SaveChanges();
            }

            context.Dispose();
        }

        private void InsertSampleData()
        {
            SalesManagement_DevContext context = new SalesManagement_DevContext();
            PasswordHash passwordHash = new PasswordHash();

            List<M_Position> po = context.M_Positions.OrderBy(x => x.PoID).ToList();
            List<M_Maker> ma = new List<M_Maker>();
            List<M_SalesOffice> so = new List<M_SalesOffice>();
            List<M_Client> cl = new List<M_Client>();
            Dictionary<int, M_Employee> em = new Dictionary<int, M_Employee>();
            List<M_MajorClassification> mc = new List<M_MajorClassification>();
            List<M_SmallClassification> sc = new List<M_SmallClassification>();
            List<M_Product> pr = new List<M_Product>();
            List<M_Message> me = new List<M_Message>();


            {
                me.Add(new M_Message()
                {
                    MsgCD = "M0001",
                    MsgComments = "登録しますか？"
                });
                me.Add(new M_Message()
                {
                    MsgCD = "M0002",
                    MsgComments = "登録が完了しました。"
                });
                me.Add(new M_Message()
                {
                    MsgCD = "M0003",
                    MsgComments = "登録に失敗しました。"
                });
                me.Add(new M_Message()
                {
                    MsgCD = "M1001",
                    MsgComments = "の情報を更新しますか？"
                });
                me.Add(new M_Message()
                {
                    MsgCD = "M1002",
                    MsgComments = "の更新が完了しました。"
                });
                me.Add(new M_Message()
                {
                    MsgCD = "M1003",
                    MsgComments = "の更新に失敗しました。"
                });
                me.Add(new M_Message()
                {
                    MsgCD = "M2001",
                    MsgComments = "を非表示にしますか？"
                });
                me.Add(new M_Message()
                {
                    MsgCD = "M2002",
                    MsgComments = "を非表示にしました。"
                });
                me.Add(new M_Message()
                {
                    MsgCD = "M2003",
                    MsgComments = "の非表示に失敗しました。"
                });
                me.Add(new M_Message()
                {
                    MsgCD = "M3001",
                    MsgComments = "の処理を確定しますか？"
                });
                me.Add(new M_Message()
                {
                    MsgCD = "M3002",
                    MsgComments = "の処理を確定しました。"
                });
                me.Add(new M_Message()
                {
                    MsgCD = "M3003",
                    MsgComments = "の確定に失敗しました。"
                });
                me.Add(new M_Message()
                {
                    MsgCD = "M4001",
                    MsgComments = "パスワードを更新しますか？"
                });
                me.Add(new M_Message()
                {
                    MsgCD = "M4002",
                    MsgComments = "パスワードを更新しました。"
                });
                me.Add(new M_Message()
                {
                    MsgCD = "M4003",
                    MsgComments = "パスワードの更新に失敗しました。"
                });
                me.Add(new M_Message()
                {
                    MsgCD = "M4004",
                    MsgComments = "IDかパスワードの入力内容が間違っています。"
                });
                me.Add(new M_Message()
                {
                    MsgCD = "M4005",
                    MsgComments = "入力されたパスワードが間違っています。"
                });

                context.M_Messages.AddRange(me);
                context.SaveChanges();
            }
            /*
            
            List<T_Order> or = new List<T_Order>();
            {
                or.Add(new T_Order
                {
                    M_SalesOffice = so[0],
                    M_Employee = em[310],
                    M_Client = cl[1],
                    ClCharge = "萬田銀次郎",
                    OrDate = new DateTime(2024, 1, 16),
                    OrStateFlag = 0,
                    OrFlag = 0,
                });
                or.Add(new T_Order
                {
                    M_SalesOffice = so[0],
                    M_Employee = em[310],
                    M_Client = cl[1],
                    ClCharge = "真木栄太郎",
                    OrDate = new DateTime(2024, 11, 15),
                    OrStateFlag = 1,
                    OrFlag = 0,
                });
                or.Add(new T_Order
                {
                    M_SalesOffice = so[0],
                    M_Employee = em[310],
                    M_Client = cl[1],
                    ClCharge = "麻田さとし",
                    OrDate = new DateTime(2024, 1, 12),
                    OrStateFlag = 0,
                    OrFlag = 2,
                });
                context.T_Orders.AddRange(or);
                context.SaveChanges();
            }
            List<T_OrderDetail> ord = new List<T_OrderDetail>();
            {
                ord.Add(new T_OrderDetail()
                {
                    T_Order = or[0],
                    M_Product = pr[2],
                    OrQuantity = 10,
                    OrTotalPrice = 200000,
                });
                ord.Add(new T_OrderDetail()
                {
                    T_Order = or[0],
                    M_Product = pr[3],
                    OrQuantity = 20,
                    OrTotalPrice = 200000,
                });
                ord.Add(new T_OrderDetail()
                {
                    T_Order = or[0],
                    M_Product = pr[1],
                    OrQuantity = 40,
                    OrTotalPrice = 200000,
                });

                context.T_OrderDetails.AddRange(ord);
                context.SaveChanges();
            }
            */
            /*

            List<T_Chumon> ch = new List<T_Chumon>();
            {
                ch.Add(new T_Chumon()
                {
                    M_SalesOffice = so[0],
                    M_Employee = em[1002],
                    M_Client = cl[1],
                    T_Order = or[0],
                    ChDate = new DateTime(2024, 1, 15),
                    ChStateFlag = 1,
                    ChFlag = 0,
                });
                ch.Add(new T_Chumon()
                {
                    M_SalesOffice = so[0],
                    M_Employee = em[1002],
                    M_Client = cl[1],
                    T_Order = or[0],
                    ChDate = new DateTime(2024, 1, 15),
                    ChStateFlag = 1,
                    ChFlag = 0,
                });
                ch.Add(new T_Chumon()
                {
                    M_SalesOffice = so[0],
                    M_Employee = em[1002],
                    M_Client = cl[1],
                    T_Order = or[0],
                    ChDate = new DateTime(2024, 1, 15),
                    ChStateFlag = 0,
                    ChFlag = 2,
                });

                context.T_Chumons.AddRange(ch);
                context.SaveChanges();
            }
            List<T_ChumonDetail> chd = new List<T_ChumonDetail>();
            {
                chd.Add(new T_ChumonDetail()
                {
                    T_Chumon = ch[0],
                    M_Product = pr[1],
                    ChQuantity = 20,
                });
                chd.Add(new T_ChumonDetail()
                {
                    T_Chumon = ch[0],
                    M_Product = pr[2],
                    ChQuantity = 40,
                });
                chd.Add(new T_ChumonDetail()
                {
                    T_Chumon = ch[0],
                    M_Product = pr[1],
                    ChQuantity = 20,
                });

                context.T_ChumonDetails.AddRange(chd);
                context.SaveChanges();
            }



                        List<T_Syukko> sy = new List<T_Syukko>();
                        {
                            sy.Add(new T_Syukko()
                            {
                                M_Client = cl[1],
                                M_SalesOffice = so[0],
                                T_Order = or[0],
                                SyDate = new DateTime(2020, 12, 11),
                                SyStateFlag = 1,
                                SyFlag = 0,
                            });

                            context.T_Syukkos.AddRange(sy);
                            context.SaveChanges();
                        }
                        List<T_SyukkoDetail> syd = new List<T_SyukkoDetail>();
                        {
                            syd.Add(new T_SyukkoDetail()
                            {
                                T_Syukko = sy[0],
                                M_Product = pr[2],
                                SyQuantity = 40,
                            });

                            context.T_SyukkoDetails.AddRange(syd);
                            context.SaveChanges();
                        }

                        List<T_Arrival> ar = new List<T_Arrival>();
                        {
                            ar.Add(new T_Arrival()
                            {
                                M_Client = cl[1],
                                M_SalesOffice = so[0],
                                M_Employee = em[1],
                                T_Order = or[0],
                                ArDate = new DateTime(2020, 12, 11),
                                ArStateFlag = 1,
                                ArFlag = 0,
                            });

                            context.T_Arrivals.AddRange(ar);
                            context.SaveChanges();
                        }

                        List<T_ArrivalDetail> ard = new List<T_ArrivalDetail>();
                        {
                            ard.Add(new T_ArrivalDetail()
                            {
                                T_Arrival = ar[0],
                                M_Product = pr[2],
                                ArQuantity = 40,
                            });

                            context.T_ArrivalDetails.AddRange(ard);
                            context.SaveChanges();
                        }




                        List<T_Shipment> sh = new List<T_Shipment>();
                        {
                            sh.Add(new T_Shipment()
                            {
                                M_Client = cl[1],
                                M_SalesOffice = so[0],
                                M_Employee = em[116],
                                T_Order = or[0],
                                ShFinishDate = new DateTime(2020, 12, 11),
                                ShStateFlag = 1,
                                ShFlag = 0,
                            });

                            context.T_Shipments.AddRange(sh);
                            context.SaveChanges();
                        }

                        List<T_ShipmentDetail> shd = new List<T_ShipmentDetail>();
                        {
                            shd.Add(new T_ShipmentDetail()
                            {
                                T_Shipment = sh[0],
                                M_Product = pr[2],
                                ShQuantity = 40,
                            });

                            context.T_ShipmentDetails.AddRange(shd);
                            context.SaveChanges();
                        }





                        List<T_Sale> sa = new List<T_Sale>();
                        List<T_SaleDetail> sad = new List<T_SaleDetail>();


                        List<T_Hattyu> ha = new List<T_Hattyu>();
                        List<T_HattyuDetail> had = new List<T_HattyuDetail>();


                        List<T_Warehousing> wa = new List<T_Warehousing>();
                        List<T_WarehousingDetail> wad = new List<T_WarehousingDetail>();


                       */

            {
                ma.Add(new M_Maker()
                {
                    MaName = "Aメーカ",
                    MaAddress = "北海道",
                    MaPhone = "090-1521-1211",
                    MaPostal = "1892376",
                    MaFAX = "090-4235-1290",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Bメーカ",
                    MaAddress = "青森県",
                    MaPhone = "090-1921-1341",
                    MaPostal = "3827367",
                    MaFAX = "090-9897-6675",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Cメーカ",
                    MaAddress = "岩手県",
                    MaPhone = "080-3789-2887",
                    MaPostal = "7829187",
                    MaFAX = "080-2667-3889",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Dメーカ",
                    MaAddress = "宮城県",
                    MaPhone = "080-2787-9981",
                    MaPostal = "7821633",
                    MaFAX = "080-1287-3318",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Eメーカ",
                    MaAddress = "秋田県",
                    MaPhone = "080-8892-1445",
                    MaPostal = "9878772",
                    MaFAX = "070-6639-9182",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Fメーカ",
                    MaAddress = "山形県",
                    MaPhone = "080-2789-7923",
                    MaPostal = "1930121",
                    MaFAX = "090-2778-1344",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Gメーカ",
                    MaAddress = "福島県",
                    MaPhone = "080-1312-3123",
                    MaPostal = "1212333",
                    MaFAX = "090-8811-8273",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Hメーカ",
                    MaAddress = "茨城県",
                    MaPhone = "080-7391-7189",
                    MaPostal = "8299282",
                    MaFAX = "090-8173-8212",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Iメーカ",
                    MaAddress = "栃木県",
                    MaPhone = "080-3892-8282",
                    MaPostal = "8703823",
                    MaFAX = "090-7293-6224",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Jメーカ",
                    MaAddress = "群馬県",
                    MaPhone = "080-6789-9131",
                    MaPostal = "7381722",
                    MaFAX = "090-6192-9182",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Kメーカ",
                    MaAddress = "埼玉県",
                    MaPhone = "070-7192-5183",
                    MaPostal = "7192131",
                    MaFAX = "090-6282-7191",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Lメーカ",
                    MaAddress = "千葉県",
                    MaPhone = "080-6729-6182",
                    MaPostal = "7182811",
                    MaFAX = "090-5281-5291",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Mメーカ",
                    MaAddress = "東京都",
                    MaPhone = "070-6172-3167",
                    MaPostal = "1312315",
                    MaFAX = "090-6811-8297",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Nメーカ",
                    MaAddress = "神奈川県",
                    MaPhone = "080-1839-3268",
                    MaPostal = "1147458",
                    MaFAX = "090-4858-8329",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Oメーカ",
                    MaAddress = "新潟県",
                    MaPhone = "070-7172-2387",
                    MaPostal = "3864382",
                    MaFAX = "090-3192-3468",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Pメーカ",
                    MaAddress = "富山県",
                    MaPhone = "080-6318-2382",
                    MaPostal = "3493689",
                    MaFAX = "090-2693-8327",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Qメーカ",
                    MaAddress = "石川県",
                    MaPhone = "080-8731-2632",
                    MaPostal = "8973832",
                    MaFAX = "090-3265-3258",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Rメーカ",
                    MaAddress = "福井県",
                    MaPhone = "070-9641-6911",
                    MaPostal = "9649232",
                    MaFAX = "090-8647-5481",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Sメーカ",
                    MaAddress = "山梨県",
                    MaPhone = "090-4673-4691",
                    MaPostal = "4875177",
                    MaFAX = "090-4587-3282",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Tメーカ",
                    MaAddress = "長野県",
                    MaPhone = "080-8269-3432",
                    MaPostal = "9264233",
                    MaFAX = "090-4821-8482",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Uメーカ",
                    MaAddress = "岐阜県",
                    MaPhone = "080-5182-1827",
                    MaPostal = "9172817",
                    MaFAX = "090-5181-5488",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Vメーカ",
                    MaAddress = "静岡県",
                    MaPhone = "090-5719-9187",
                    MaPostal = "1928717",
                    MaFAX = "090-6181-4765",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Wメーカ",
                    MaAddress = "愛知県",
                    MaPhone = "080-5181-8718",
                    MaPostal = "7199112",
                    MaFAX = "080-5868-4766",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Xメーカ",
                    MaAddress = "三重県",
                    MaPhone = "090-6187-4189",
                    MaPostal = "3876879",
                    MaFAX = "080-7181-5781",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Yメーカ",
                    MaAddress = "滋賀県",
                    MaPhone = "070-5875-3122",
                    MaPostal = "9187722",
                    MaFAX = "090-3123-1182",
                    MaFlag = 0,
                });
                ma.Add(new M_Maker()
                {
                    MaName = "Zメーカ",
                    MaAddress = "京都府",
                    MaPhone = "080-7681-9611",
                    MaPostal = "7329811",
                    MaFAX = "090-6718-6191",
                    MaFlag = 0,
                });
                context.M_Makers.AddRange(ma);
                context.SaveChanges();
            }
            {
                so.Add(new M_SalesOffice()
                {
                    SoName = "札幌営業所",
                    SoAddress = "北海道札幌市0-0-1",
                    SoPhone = "00-3819-2321",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0000",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "青森営業所",
                    SoAddress = "青森県青森市新町0-0-2",
                    SoPhone = "00-3819-2322",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0001",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "盛岡営業所",
                    SoAddress = "岩手県盛岡市長橋町0-0-3",
                    SoPhone = "00-3819-2323",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0002",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "仙台営業所",
                    SoAddress = "宮城県仙台市杜王町0-0-4",
                    SoPhone = "00-3819-2324",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0003",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "秋田営業所",
                    SoAddress = "秋田県秋田市新島町0-0-5",
                    SoPhone = "00-3819-2325",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0004",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "山形営業所",
                    SoAddress = "山形県山形市城西町0-0-6",
                    SoPhone = "00-3819-2326",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0005",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "福島営業所",
                    SoAddress = "福島県福島市松川町0-0-7",
                    SoPhone = "00-3819-2327",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0006",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "つくば営業所",
                    SoAddress = "茨城県つくば市台町0-0-8",
                    SoPhone = "00-3819-2328",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0007",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "宇都宮営業所",
                    SoAddress = "栃木県宇都宮市鶴田町0-0-9",
                    SoPhone = "00-3819-2329",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0008",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "群馬営業所",
                    SoAddress = "群馬県群馬市群馬町0-1-0",
                    SoPhone = "00-3819-2330",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0009",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "春日部営業所",
                    SoAddress = "埼玉県春日部市矢木崎町0-1-1",
                    SoPhone = "00-3819-2331",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0010",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "千葉市",
                    SoAddress = "千葉県千葉市都町0-1-2",
                    SoPhone = "00-3819-2332",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0011",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "東京営業所",
                    SoAddress = "東京都町田市原田町0-1-3",
                    SoPhone = "00-3819-2333",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0012",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "相模原営業所",
                    SoAddress = "神奈川県相模原市相0-1-4",
                    SoPhone = "00-3819-2334",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0013",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "新潟営業所",
                    SoAddress = "新潟県新潟市古町0-1-5",
                    SoPhone = "00-3819-2335",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0014",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "富山営業所",
                    SoAddress = "富山県富山市婦中町0-1-6",
                    SoPhone = "00-3819-2336",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0015",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "金沢営業所",
                    SoAddress = "石川県金沢市堅町0-1-7",
                    SoPhone = "00-3819-2337",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0016",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "福井営業所",
                    SoAddress = "福井県福井市高尾町0-1-8",
                    SoPhone = "00-3819-2338",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0017",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "山梨営業所",
                    SoAddress = "山梨県山梨市牧丘町0-1-9",
                    SoPhone = "00-3819-2339",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0018",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "長野営業所",
                    SoAddress = "長野県長野市中条地区0-2-0",
                    SoPhone = "00-3819-2340",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0019",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "岐阜営業所",
                    SoAddress = "岐阜県岐阜市竜田町0-2-1",
                    SoPhone = "00-3819-2341",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0020",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "静岡営業所",
                    SoAddress = "静岡県静岡市葵区0-2-2",
                    SoPhone = "00-3819-2342",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0021",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "名古屋営業所",
                    SoAddress = "愛知県名古屋市栄0-2-3",
                    SoPhone = "00-3819-2343",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0022",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "津営業所",
                    SoAddress = "三重県津市片田町0-2-4",
                    SoPhone = "00-3819-2344",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0023",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "大津営業所",
                    SoAddress = "滋賀県大津市松原町0-2-5",
                    SoPhone = "00-3819-2345",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0024",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "京都営業所",
                    SoAddress = "京都府京都市中京区0-2-6",
                    SoPhone = "000-3819-2346",
                    SoPostal = "0000000",
                    SoFAX = "121-111-0025",
                    SoFlag = 0,
                });
                so.Add(new M_SalesOffice()
                {
                    SoName = "大阪営業所",
                    SoAddress = "大阪府大阪市天王寺区6-8^4",
                    SoPhone = "06-6772-2233",
                    SoPostal = "0000000",
                    SoFAX = "000-000-0000",
                    SoFlag = 0,
                });
                context.M_SalesOffices.AddRange(so);
                context.SaveChanges();
            }
            {
                cl.Add(new M_Client()
                {
                    ClName = "上村電機",
                    ClAddress = "京都府京都市伏見区塩屋町3-9-95",
                    ClPhone = "077-672-6006",
                    ClPostal = "6128046",
                    ClFAX = "077-581-0164",
                    ClFlag = 0,
                    M_SalesOffice = so[3],
                });
                cl.Add(new M_Client()
                {
                    ClName = "萬田金融",
                    ClAddress = "大阪府大阪市西区北堀江1丁目22-3",
                    ClPhone = "06-8757-6267",
                    ClPostal = "5500014",
                    ClFAX = "06-8757-6267",
                    ClFlag = 0,
                    M_SalesOffice = so[0],
                });
                cl.Add(new M_Client()
                {
                    ClName = "宝田電機",
                    ClAddress = "大阪府大阪市中央区和泉町2-5-46",
                    ClPhone = "06-1423-1895",
                    ClPostal = "5720806",
                    ClFAX = "06-1374-4358",
                    ClFlag = 0,
                    M_SalesOffice = so[0],
                });
                cl.Add(new M_Client()
                {
                    ClName = "INATUGI",
                    ClAddress = "大阪府茨木市横江2-5-60",
                    ClPhone = "072-02-5171",
                    ClPostal = "5670044",
                    ClFAX = "072-018-0116",
                    ClFlag = 0,
                    M_SalesOffice = so[0],
                });
                cl.Add(new M_Client()
                {
                    ClName = "水野電機",
                    ClAddress = "大阪府豊中市末広町2-6-13",
                    ClPhone = "06-2096-0974",
                    ClPostal = "5600024",
                    ClFAX = "06-2434-2434",
                    ClFlag = 0,
                    M_SalesOffice = so[1],
                });
                cl.Add(new M_Client()
                {
                    ClName = "ショップ赤川",
                    ClAddress = "大阪府大阪市天王寺区上本町",
                    ClPhone = "090-1111-1111",
                    ClPostal = "5430001",
                    ClFAX = "06-1111-1111",
                    ClFlag = 0,
                    M_SalesOffice = so[0],
                });
                cl.Add(new M_Client()
                {
                    ClName = "成田",
                    ClAddress = "奈良県御所市船路2-8-87",
                    ClPhone = "0746-0-1160",
                    ClPostal = "6392268",
                    ClFAX = "0746-0-1160",
                    ClFlag = 0,
                    M_SalesOffice = so[2],
                });

                context.M_Clients.AddRange(cl);
                context.SaveChanges();
            }

            {
                if (context.M_Employees.Where(x => x.EmID == 1).Count() == 0)
                {
                    string password = "1111";
                    string salt;
                    string hashedPassword = passwordHash.GenerateSaltedHash(password, out salt);

                    em.Add(1, new M_Employee()
                    {
                        EmID = 1,
                        EmName = "田中杏一",
                        EmHiredate = new DateTime(2020, 4, 17),
                        EmPassword = hashedPassword,
                        EmPhone = "06-0000-0000",
                        M_SalesOffice = so[26],
                        M_Position = po[0],
                        EmSalt = salt,
                    });
                }
                if (context.M_Employees.Where(x => x.EmID == 2).Count() == 0)
                {
                    string password = "2222";
                    string salt;
                    string hashedPassword = passwordHash.GenerateSaltedHash(password, out salt);

                    em.Add(2, new M_Employee()
                    {
                        EmID = 2,
                        EmName = "太田秀哉",
                        EmHiredate = new DateTime(2020, 4, 17),
                        EmPassword = hashedPassword,
                        EmPhone = "06-0000-0000",
                        M_SalesOffice = so[26],
                        M_Position = po[0],
                        EmSalt = salt,
                    });
                }
                if (context.M_Employees.Where(x => x.EmID == 3).Count() == 0)
                {
                    string password = "3333";
                    string salt;
                    string hashedPassword = passwordHash.GenerateSaltedHash(password, out salt);

                    em.Add(3, new M_Employee()
                    {
                        EmID = 3,
                        EmName = "西山和樹",
                        EmHiredate = new DateTime(2020, 4, 17),
                        EmPassword = hashedPassword,
                        EmPhone = "06-0000-0000",
                        M_SalesOffice = so[26],
                        M_Position = po[1],
                        EmSalt = salt,
                    });
                }
                if (context.M_Employees.Where(x => x.EmID == 4).Count() == 0)
                {
                    string password = "4444";
                    string salt;
                    string hashedPassword = passwordHash.GenerateSaltedHash(password, out salt);
                    em.Add(4, new M_Employee()
                    {
                        EmID = 4,
                        EmName = "中野紀幸",
                        EmHiredate = new DateTime(2020, 4, 17),
                        EmPassword = hashedPassword,
                        EmPhone = "06-0000-0000",
                        M_SalesOffice = so[26],
                        M_Position = po[1],
                        EmSalt = salt
                    });
                }
                if (context.M_Employees.Where(x => x.EmID == 5).Count() == 0)
                {
                    string password = "5555";
                    string salt;
                    string hashedPassword = passwordHash.GenerateSaltedHash(password, out salt);
                    em.Add(5, new M_Employee()
                    {
                        EmID = 5,
                        EmName = "千田真隆",
                        EmHiredate = new DateTime(2020, 4, 17),
                        EmPassword = hashedPassword,
                        EmPhone = "06-0000-0000",
                        M_SalesOffice = so[26],
                        M_Position = po[2],
                        EmSalt = salt
                    });
                }
                if (context.M_Employees.Where(x => x.EmID == 6).Count() == 0)
                {
                    string password = "6666";
                    string salt;
                    string hashedPassword = passwordHash.GenerateSaltedHash(password, out salt);
                    em.Add(6, new M_Employee()
                    {
                        EmID = 6,
                        EmName = "山路和希",
                        EmHiredate = new DateTime(2020, 4, 17),
                        EmPassword = hashedPassword,
                        EmPhone = "06-0000-0000",
                        M_SalesOffice = so[26],
                        M_Position = po[2],
                        EmSalt = salt
                    });
                }
                if (context.M_Employees.Where(x => x.EmID == 7).Count() == 0)
                {
                    string password = "7777";
                    string salt;
                    string hashedPassword = passwordHash.GenerateSaltedHash(password, out salt);
                    em.Add(7, new M_Employee()
                    {
                        EmID = 7,
                        EmName = "安井悠太",
                        EmHiredate = new DateTime(2020, 4, 17),
                        EmPassword = hashedPassword,
                        EmPhone = "06-0000-0000",
                        M_SalesOffice = so[26],
                        M_Position = po[2],
                        EmSalt = salt
                    });
                }
                if (context.M_Employees.Where(x => x.EmID == 116).Count() == 0)
                {
                    string password = "0116";
                    string salt;
                    string hashedPassword = passwordHash.GenerateSaltedHash(password, out salt);
                    em.Add(116, new M_Employee()
                    {
                        EmID = 116,
                        EmName = "坂口郁美",
                        EmHiredate = new DateTime(1980, 6, 17),
                        EmPassword = hashedPassword,
                        EmPhone = "06-6813-5485",
                        M_SalesOffice = so[1],
                        M_Position = po[2],
                        EmSalt = salt
                    });
                }
                if (context.M_Employees.Where(x => x.EmID == 310).Count() == 0)
                {
                    string password = "1310";
                    string salt;
                    string hashedPassword = passwordHash.GenerateSaltedHash(password, out salt);
                    em.Add(310, new M_Employee()
                    {
                        EmID = 310,
                        EmName = "高谷春男",
                        EmHiredate = new DateTime(1973, 3, 21),
                        EmPassword = hashedPassword,
                        EmPhone = "06-6356-8742",
                        M_SalesOffice = so[0],
                        M_Position = po[1],
                        EmSalt = salt,
                    });
                }
                if (context.M_Employees.Where(x => x.EmID == 1002).Count() == 0)
                {
                    string password = "1234";
                    string salt;
                    string hashedPassword = passwordHash.GenerateSaltedHash(password, out salt);
                    em.Add(1002, new M_Employee()
                    {
                        EmID = 1002,
                        EmName = "日下部俊夫",
                        EmHiredate = new DateTime(1990, 9, 4),
                        EmPassword =hashedPassword,
                        EmPhone = "06-6579-0622",
                        M_SalesOffice = so[0],
                        M_Position = po[1],
                        EmSalt = salt
                    });
                }
                if (context.M_Employees.Where(x => x.EmID == 1007).Count() == 0)
                {
                    string password = "1007";
                    string salt;
                    string hashedPassword = passwordHash.GenerateSaltedHash(password, out salt);
                    em.Add(1007, new M_Employee()
                    {
                        EmID = 1007,
                        EmName = "岸本芽生",
                        EmHiredate = new DateTime(1997, 2, 4),
                        EmPassword =hashedPassword,
                        EmPhone = "075-425-3371",
                        M_SalesOffice = so[2],
                        M_Position = po[1],
                        EmSalt = salt
                    });
                }
                if (context.M_Employees.Where(x => x.EmID == 1111).Count() == 0)
                {
                    string password = "999";
                    string salt;
                    string hashedPassword = passwordHash.GenerateSaltedHash(password, out salt);
                    em.Add(1111, new M_Employee()
                    {
                        EmID = 1111,
                        EmName = "奥村敦彦",
                        EmHiredate = new DateTime(1985, 3, 17),
                        EmPassword = hashedPassword,
                        EmPhone = "079-145-6121",
                        M_SalesOffice = so[3],
                        M_Position = po[2],
                        EmSalt = salt,
                    });
                }
                if (context.M_Employees.Where(x => x.EmID == 1208).Count() == 0)
                {
                    string password = "265";
                    string salt;
                    string hashedPassword = passwordHash.GenerateSaltedHash(password, out salt);
                    em.Add(1208, new M_Employee()
                    {
                        EmID = 1208,
                        EmName = "渋谷秋昴",
                        EmHiredate = new DateTime(1994, 1, 31),
                        EmPassword = hashedPassword,
                        EmPhone = "0790-68-8043",
                        M_SalesOffice = so[4],
                        M_Position = po[1],
                        EmSalt = salt
                    });
                }
                if (context.M_Employees.Where(x => x.EmID == 1227).Count() == 0)
                {
                    string password = "1227";
                    string salt;
                    string hashedPassword = passwordHash.GenerateSaltedHash(password, out salt);
                    em.Add(1227, new M_Employee()
                    {
                        EmID = 1227,
                        EmName = "生田徳次郎",
                        EmHiredate = new DateTime(1964, 3, 20),
                        EmPassword =hashedPassword,
                        EmPhone = "06-3021-1630",
                        M_SalesOffice = so[0],
                        M_Position = po[0],
                        EmSalt  = salt
                    });
                }
                context.M_Employees.AddRange(em.Values);
                context.SaveChanges();
                foreach (var emp in context.M_Employees)
                {
                    em[emp.EmID] = emp;
                }
            }
            {
                mc.Add(new M_MajorClassification()
                {
                    McName = "テレビ・レコーダー",
                    McFlag = 0,
                });
                mc.Add(new M_MajorClassification()
                {
                    McName = "エアコン・冷蔵庫・洗濯機",
                    McFlag = 0,
                });
                mc.Add(new M_MajorClassification()
                {
                    McName = "オーディオ・イヤホン・ヘッドホン",
                    McFlag = 0,
                });
                mc.Add(new M_MajorClassification()
                {
                    McName = "携帯電話・スマートフォン",
                    McFlag = 0,
                });
                context.M_MajorCassifications.AddRange(mc);
                context.SaveChanges();
            }
            {
                sc.Add(new M_SmallClassification()
                {
                    M_MajorClassification = mc[0],
                    ScName = "テレビ",
                    ScFlag = 0,
                });
                sc.Add(new M_SmallClassification()
                {
                    M_MajorClassification = mc[0],
                    ScName = "レコーダー",
                    ScFlag = 0,
                });
                sc.Add(new M_SmallClassification()
                {
                    M_MajorClassification = mc[1],
                    ScName = "エアコン",
                    ScFlag = 0,
                });
                sc.Add(new M_SmallClassification()
                {
                    M_MajorClassification = mc[1],
                    ScName = "冷蔵庫",
                    ScFlag = 0,
                });
                sc.Add(new M_SmallClassification()
                {
                    M_MajorClassification = mc[1],
                    ScName = "洗濯機",
                    ScFlag = 0,
                });
                sc.Add(new M_SmallClassification()
                {
                    M_MajorClassification = mc[2],
                    ScName = "オーディオ",
                    ScFlag = 0,
                });
                sc.Add(new M_SmallClassification()
                {
                    M_MajorClassification = mc[2],
                    ScName = "イヤホン",
                    ScFlag = 0,
                });
                sc.Add(new M_SmallClassification()
                {
                    M_MajorClassification = mc[2],
                    ScName = "ヘッドホン",
                    ScFlag = 0,
                });
                sc.Add(new M_SmallClassification()
                {
                    M_MajorClassification = mc[3],
                    ScName = "携帯電話",
                    ScFlag = 0,
                });
                sc.Add(new M_SmallClassification()
                {
                    M_MajorClassification = mc[3],
                    ScName = "スマートフォン",
                    ScFlag = 0,
                });
                context.M_SmallClassifications.AddRange(sc);
                context.SaveChanges();
            }
            {
                pr.Add(new M_Product()
                {
                    M_Maker = ma[0],
                    PrName = "テレビA",
                    Price = 50000,
                    PrSafetyStock = 30,
                    M_SmallClassification = sc[0],
                    PrModelNumber = "0001",
                    PrColor = "黒",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });


                pr.Add(new M_Product()
                {
                    M_Maker = ma[1],
                    PrName = "テレビB",
                    Price = 30000,
                    PrSafetyStock = 40,
                    M_SmallClassification = sc[0],
                    PrModelNumber = "0002",
                    PrColor = "白",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[2],
                    PrName = "テレビC",
                    Price = 20000,
                    PrSafetyStock = 30,
                    M_SmallClassification = sc[0],
                    PrModelNumber = "0003",
                    PrColor = "黄緑",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[3],
                    PrName = "テレビD",
                    Price = 25000,
                    PrSafetyStock = 50,
                    M_SmallClassification = sc[0],
                    PrModelNumber = "0004",
                    PrColor = "紫",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });


                pr.Add(new M_Product()
                {
                    M_Maker = ma[4],
                    PrName = "テレビE",
                    Price = 60000,
                    PrSafetyStock = 15,
                    M_SmallClassification = sc[0],
                    PrModelNumber = "0005",
                    PrColor = "緑",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[5],
                    PrName = "テレビF",
                    Price = 15000,
                    PrSafetyStock = 50,
                    M_SmallClassification = sc[0],
                    PrModelNumber = "0006",
                    PrColor = "黄",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[6],
                    PrName = "テレビG",
                    Price = 40000,
                    PrSafetyStock = 40,
                    M_SmallClassification = sc[0],
                    PrModelNumber = "0007",
                    PrColor = "青",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[7],
                    PrName = "テレビH",
                    Price = 62000,
                    PrSafetyStock = 10,
                    M_SmallClassification = sc[0],
                    PrModelNumber = "0008",
                    PrColor = "赤",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[8],
                    PrName = "テレビI",
                    Price = 80000,
                    PrSafetyStock = 5,
                    M_SmallClassification = sc[0],
                    PrModelNumber = "0009",
                    PrColor = "金",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });


                pr.Add(new M_Product()
                {
                    M_Maker = ma[9],
                    PrName = "レコーダーA",
                    Price = 15000,
                    PrSafetyStock = 20,
                    M_SmallClassification = sc[1],
                    PrModelNumber = "0101",
                    PrColor = "赤",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[10],
                    PrName = "レコーダーB",
                    Price = 20000,
                    PrSafetyStock = 25,
                    M_SmallClassification = sc[1],
                    PrModelNumber = "0102",
                    PrColor = "青",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[11],
                    PrName = "レコーダーC",
                    Price = 30000,
                    PrSafetyStock = 90,
                    M_SmallClassification = sc[1],
                    PrModelNumber = "0103",
                    PrColor = "黄",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[12],
                    PrName = "レコーダーD",
                    Price = 10000,
                    PrSafetyStock = 20,
                    M_SmallClassification = sc[1],
                    PrModelNumber = "0104",
                    PrColor = "黒",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[13],
                    PrName = "レコーダーE",
                    Price = 15000,
                    PrSafetyStock = 25,
                    M_SmallClassification = sc[1],
                    PrModelNumber = "0105",
                    PrColor = "緑",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[14],
                    PrName = "レコーダーF",
                    Price = 32000,
                    PrSafetyStock = 50,
                    M_SmallClassification = sc[1],
                    PrModelNumber = "0106",
                    PrColor = "紫",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[15],
                    PrName = "レコーダーG",
                    Price = 24000,
                    PrSafetyStock = 18,
                    M_SmallClassification = sc[1],
                    PrModelNumber = "0107",
                    PrColor = "金",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[16],
                    PrName = "レコーダーH",
                    Price = 60000,
                    PrSafetyStock = 15,
                    M_SmallClassification = sc[1],
                    PrModelNumber = "0108",
                    PrColor = "銀",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[17],
                    PrName = "レコーダーI",
                    Price = 8000,
                    PrSafetyStock = 35,
                    M_SmallClassification = sc[1],
                    PrModelNumber = "0109",
                    PrColor = "橙",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[18],
                    PrName = "レコーダーJ",
                    Price = 45000,
                    PrSafetyStock = 60,
                    M_SmallClassification = sc[1],
                    PrModelNumber = "0110",
                    PrColor = "白",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[19],
                    PrName = "エアコンA",
                    Price = 60000,
                    PrSafetyStock = 35,
                    M_SmallClassification = sc[2],
                    PrModelNumber = "0201",
                    PrColor = "黒",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });


                pr.Add(new M_Product()
                {
                    M_Maker = ma[20],
                    PrName = "エアコンB",
                    Price = 30000,
                    PrSafetyStock = 20,
                    M_SmallClassification = sc[2],
                    PrModelNumber = "0202",
                    PrColor = "赤",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[21],
                    PrName = "エアコンC",
                    Price = 15000,
                    PrSafetyStock = 15,
                    M_SmallClassification = sc[2],
                    PrModelNumber = "0203",
                    PrColor = "白",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });

                pr.Add(new M_Product()
                {
                    M_Maker = ma[22],
                    PrName = "エアコンD",
                    Price = 45000,
                    PrSafetyStock = 35,
                    M_SmallClassification = sc[2],
                    PrModelNumber = "0204",
                    PrColor = "青",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[0],
                    PrName = "エアコンE",
                    Price = 75000,
                    PrSafetyStock = 10,
                    M_SmallClassification = sc[2],
                    PrModelNumber = "0205",
                    PrColor = "赤",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[1],
                    PrName = "エアコンF",
                    Price = 10000,
                    PrSafetyStock = 15,
                    M_SmallClassification = sc[2],
                    PrModelNumber = "0206",
                    PrColor = "青",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[2],
                    PrName = "エアコンG",
                    Price = 20000,
                    PrSafetyStock = 20,
                    M_SmallClassification = sc[2],
                    PrModelNumber = "0207",
                    PrColor = "黄",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[3],
                    PrName = "エアコンH",
                    Price = 30000,
                    PrSafetyStock = 25,
                    M_SmallClassification = sc[2],
                    PrModelNumber = "0208",
                    PrColor = "緑",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[4],
                    PrName = "エアコンI",
                    Price = 40000,
                    PrSafetyStock = 30,
                    M_SmallClassification = sc[2],
                    PrModelNumber = "0209",
                    PrColor = "白",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });


                pr.Add(new M_Product()
                {
                    M_Maker = ma[5],
                    PrName = "冷蔵庫A",
                    Price = 50000,
                    PrSafetyStock = 35,
                    M_SmallClassification = sc[3],
                    PrModelNumber = "0301",
                    PrColor = "黒",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[6],
                    PrName = "冷蔵庫B",
                    Price = 60000,
                    PrSafetyStock = 40,
                    M_SmallClassification = sc[3],
                    PrModelNumber = "0302",
                    PrColor = "紫",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[7],
                    PrName = "冷蔵庫C",
                    Price = 70000,
                    PrSafetyStock = 45,
                    M_SmallClassification = sc[3],
                    PrModelNumber = "0303",
                    PrColor = "橙",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[8],
                    PrName = "冷蔵庫D",
                    Price = 80000,
                    PrSafetyStock = 50,
                    M_SmallClassification = sc[3],
                    PrModelNumber = "0304",
                    PrColor = "青",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[9],
                    PrName = "冷蔵庫E",
                    Price = 90000,
                    PrSafetyStock = 55,
                    M_SmallClassification = sc[3],
                    PrModelNumber = "0305",
                    PrColor = "銀",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[10],
                    PrName = "冷蔵庫F",
                    Price = 15000,
                    PrSafetyStock = 60,
                    M_SmallClassification = sc[3],
                    PrModelNumber = "0306",
                    PrColor = "金",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[11],
                    PrName = "冷蔵庫G",
                    Price = 25000,
                    PrSafetyStock = 65,
                    M_SmallClassification = sc[3],
                    PrModelNumber = "0307",
                    PrColor = "黒",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[12],
                    PrName = "冷蔵庫H",
                    Price = 35000,
                    PrSafetyStock = 70,
                    M_SmallClassification = sc[3],
                    PrModelNumber = "0308",
                    PrColor = "白",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[13],
                    PrName = "冷蔵庫I",
                    Price = 45000,
                    PrSafetyStock = 75,
                    M_SmallClassification = sc[3],
                    PrModelNumber = "0309",
                    PrColor = "紫",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });


                pr.Add(new M_Product()
                {
                    M_Maker = ma[14],
                    PrName = "冷蔵庫J",
                    Price = 55000,
                    PrSafetyStock = 80,
                    M_SmallClassification = sc[3],
                    PrModelNumber = "0310",
                    PrColor = "青",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });


                pr.Add(new M_Product()
                {
                    M_Maker = ma[15],
                    PrName = "洗濯機A",
                    Price = 65000,
                    PrSafetyStock = 85,
                    M_SmallClassification = sc[4],
                    PrModelNumber = "0401",
                    PrColor = "金",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[16],
                    PrName = "洗濯機B",
                    Price = 75000,
                    PrSafetyStock = 90,
                    M_SmallClassification = sc[4],
                    PrModelNumber = "0402",
                    PrColor = "銀",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[17],
                    PrName = "洗濯機C",
                    Price = 85000,
                    PrSafetyStock = 95,
                    M_SmallClassification = sc[4],
                    PrModelNumber = "0403",
                    PrColor = "緑",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[0],
                    PrName = "洗濯機D",
                    Price = 15000,
                    PrSafetyStock = 10,
                    M_SmallClassification = sc[4],
                    PrModelNumber = "0404",
                    PrColor = "紅",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[1],
                    PrName = "洗濯機E",
                    Price = 20000,
                    PrSafetyStock = 15,
                    M_SmallClassification = sc[4],
                    PrModelNumber = "0405",
                    PrColor = "紺",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[2],
                    PrName = "洗濯機F",
                    Price = 25000,
                    PrSafetyStock = 20,
                    M_SmallClassification = sc[4],
                    PrModelNumber = "0406",
                    PrColor = "紫",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[3],
                    PrName = "洗濯機G",
                    Price = 35000,
                    PrSafetyStock = 30,
                    M_SmallClassification = sc[4],
                    PrModelNumber = "0407",
                    PrColor = "黒",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[4],
                    PrName = "洗濯機H",
                    Price = 40000,
                    PrSafetyStock = 35,
                    M_SmallClassification = sc[4],
                    PrModelNumber = "0408",
                    PrColor = "白",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[5],
                    PrName = "洗濯機I",
                    Price = 45000,
                    PrSafetyStock = 40,
                    M_SmallClassification = sc[4],
                    PrModelNumber = "0409",
                    PrColor = "緑",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[6],
                    PrName = "洗濯機J",
                    Price = 50000,
                    PrSafetyStock = 45,
                    M_SmallClassification = sc[4],
                    PrModelNumber = "0410",
                    PrColor = "黄",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[7],
                    PrName = "洗濯機K",
                    Price = 55000,
                    PrSafetyStock = 50,
                    M_SmallClassification = sc[4],
                    PrModelNumber = "0411",
                    PrColor = "青",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[8],
                    PrName = "洗濯機L",
                    Price = 60000,
                    PrSafetyStock = 55,
                    M_SmallClassification = sc[4],
                    PrModelNumber = "0412",
                    PrColor = "赤",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[9],
                    PrName = "オーディオA",
                    Price = 5000,
                    PrSafetyStock = 10,
                    M_SmallClassification = sc[5],
                    PrModelNumber = "0501",
                    PrColor = "白",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });


                pr.Add(new M_Product()
                {
                    M_Maker = ma[10],
                    PrName = "オーディオB",
                    Price = 6000,
                    PrSafetyStock = 15,
                    M_SmallClassification = sc[5],
                    PrModelNumber = "0502",
                    PrColor = "赤",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[11],
                    PrName = "オーディオC",
                    Price = 7000,
                    PrSafetyStock = 20,
                    M_SmallClassification = sc[5],
                    PrModelNumber = "0503",
                    PrColor = "紫",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[12],
                    PrName = "オーディオD",
                    Price = 8000,
                    PrSafetyStock = 25,
                    M_SmallClassification = sc[5],
                    PrModelNumber = "0504",
                    PrColor = "銅",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[13],
                    PrName = "オーディオE",
                    Price = 9000,
                    PrSafetyStock = 30,
                    M_SmallClassification = sc[5],
                    PrModelNumber = "0505",
                    PrColor = "黄",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[14],
                    PrName = "オーディオF",
                    Price = 10000,
                    PrSafetyStock = 35,
                    M_SmallClassification = sc[5],
                    PrModelNumber = "0506",
                    PrColor = "青",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[15],
                    PrName = "オーディオG",
                    Price = 15000,
                    PrSafetyStock = 40,
                    M_SmallClassification = sc[5],
                    PrModelNumber = "0507",
                    PrColor = "桃",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[16],
                    PrName = "オーディオH",
                    Price = 20000,
                    PrSafetyStock = 45,
                    M_SmallClassification = sc[5],
                    PrModelNumber = "0508",
                    PrColor = "橙",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[17],
                    PrName = "オーディオI",
                    Price = 25000,
                    PrSafetyStock = 50,
                    M_SmallClassification = sc[5],
                    PrModelNumber = "0509",
                    PrColor = "灰",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[18],
                    PrName = "オーディオJ",
                    Price = 30000,
                    PrSafetyStock = 55,
                    M_SmallClassification = sc[5],
                    PrModelNumber = "0510",
                    PrColor = "墨",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[19],
                    PrName = "オーディオK",
                    Price = 35000,
                    PrSafetyStock = 60,
                    M_SmallClassification = sc[5],
                    PrModelNumber = "0511",
                    PrColor = "茶",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[20],
                    PrName = "オーディオL",
                    Price = 40000,
                    PrSafetyStock = 65,
                    M_SmallClassification = sc[5],
                    PrModelNumber = "0512",
                    PrColor = "銀",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });


                pr.Add(new M_Product()
                {
                    M_Maker = ma[21],
                    PrName = "ヘッドフォンA",
                    Price = 1000,
                    PrSafetyStock = 20,
                    M_SmallClassification = sc[6],
                    PrModelNumber = "0601",
                    PrColor = "金",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[22],
                    PrName = "ヘッドフォンB",
                    Price = 2000,
                    PrSafetyStock = 25,
                    M_SmallClassification = sc[6],
                    PrModelNumber = "0602",
                    PrColor = "紅",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[23],
                    PrName = "ヘッドフォンC",
                    Price = 3000,
                    PrSafetyStock = 30,
                    M_SmallClassification = sc[6],
                    PrModelNumber = "0603",
                    PrColor = "朱",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[24],
                    PrName = "ヘッドフォンD",
                    Price = 4000,
                    PrSafetyStock = 35,
                    M_SmallClassification = sc[6],
                    PrModelNumber = "0604",
                    PrColor = "紺",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[0],
                    PrName = "ヘッドフォンE",
                    Price = 5000,
                    PrSafetyStock = 40,
                    M_SmallClassification = sc[6],
                    PrModelNumber = "0605",
                    PrColor = "金",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[1],
                    PrName = "ヘッドフォンF",
                    Price = 6000,
                    PrSafetyStock = 45,
                    M_SmallClassification = sc[6],
                    PrModelNumber = "0606",
                    PrColor = "桃",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[2],
                    PrName = "ヘッドフォンG",
                    Price = 7000,
                    PrSafetyStock = 50,
                    M_SmallClassification = sc[6],
                    PrModelNumber = "0607",
                    PrColor = "紫",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[3],
                    PrName = "ヘッドフォンH",
                    Price = 8000,
                    PrSafetyStock = 55,
                    M_SmallClassification = sc[6],
                    PrModelNumber = "0608",
                    PrColor = "黒",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[4],
                    PrName = "ヘッドフォンI",
                    Price = 9000,
                    PrSafetyStock = 60,
                    M_SmallClassification = sc[6],
                    PrModelNumber = "0609",
                    PrColor = "白",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[5],
                    PrName = "ヘッドフォンJ",
                    Price = 10000,
                    PrSafetyStock = 65,
                    M_SmallClassification = sc[6],
                    PrModelNumber = "0610",
                    PrColor = "緑",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[6],
                    PrName = "ヘッドフォンK",
                    Price = 15000,
                    PrSafetyStock = 70,
                    M_SmallClassification = sc[6],
                    PrModelNumber = "0611",
                    PrColor = "黄",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[7],
                    PrName = "ヘッドフォンL",
                    Price = 20000,
                    PrSafetyStock = 80,
                    M_SmallClassification = sc[6],
                    PrModelNumber = "0612",
                    PrColor = "青",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[8],
                    PrName = "ヘッドフォンM",
                    Price = 9000,
                    PrSafetyStock = 85,
                    M_SmallClassification = sc[6],
                    PrModelNumber = "0613",
                    PrColor = "赤",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });


                pr.Add(new M_Product()
                {
                    M_Maker = ma[15],
                    PrName = "イヤホンA",
                    Price = 1500,
                    PrSafetyStock = 50,
                    M_SmallClassification = sc[7],
                    PrModelNumber = "0701",
                    PrColor = "白",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[15],
                    PrName = "イヤホンB",
                    Price = 3000,
                    PrSafetyStock = 100,
                    M_SmallClassification = sc[7],
                    PrModelNumber = "0702",
                    PrColor = "黒",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[15],
                    PrName = "イヤホンC",
                    Price = 1500,
                    PrSafetyStock = 75,
                    M_SmallClassification = sc[7],
                    PrModelNumber = "0703",
                    PrColor = "赤",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });


                pr.Add(new M_Product()
                {
                    M_Maker = ma[16],
                    PrName = "イヤホンD",
                    Price = 6000,
                    PrSafetyStock = 15,
                    M_SmallClassification = sc[7],
                    PrModelNumber = "0704",
                    PrColor = "金",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[17],
                    PrName = "イヤホンE",
                    Price = 4500,
                    PrSafetyStock = 50,
                    M_SmallClassification = sc[7],
                    PrModelNumber = "0705",
                    PrColor = "青",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[18],
                    PrName = "イヤホンF",
                    Price = 3000,
                    PrSafetyStock = 35,
                    M_SmallClassification = sc[7],
                    PrModelNumber = "0706",
                    PrColor = "黄",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[19],
                    PrName = "イヤホンG",
                    Price = 6200,
                    PrSafetyStock = 75,
                    M_SmallClassification = sc[7],
                    PrModelNumber = "0707",
                    PrColor = "緑",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[20],
                    PrName = "イヤホンH",
                    Price = 8000,
                    PrSafetyStock = 60,
                    M_SmallClassification = sc[7],
                    PrModelNumber = "0708",
                    PrColor = "銀",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[21],
                    PrName = "イヤホンI",
                    Price = 6000,
                    PrSafetyStock = 30,
                    M_SmallClassification = sc[7],
                    PrModelNumber = "0709",
                    PrColor = "橙",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[22],
                    PrName = "イヤホンJ",
                    Price = 2000,
                    PrSafetyStock = 40,
                    M_SmallClassification = sc[7],
                    PrModelNumber = "0710",
                    PrColor = "赤",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[23],
                    PrName = "イヤホンK",
                    Price = 500,
                    PrSafetyStock = 15,
                    M_SmallClassification = sc[7],
                    PrModelNumber = "0711",
                    PrColor = "白",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[24],
                    PrName = "イヤホンL",
                    Price = 4000,
                    PrSafetyStock = 30,
                    M_SmallClassification = sc[7],
                    PrModelNumber = "0712",
                    PrColor = "黒",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "イヤホンM",
                    Price = 2500,
                    PrSafetyStock = 50,
                    M_SmallClassification = sc[7],
                    PrModelNumber = "0713",
                    PrColor = "青",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });


                pr.Add(new M_Product()
                {
                    M_Maker = ma[17],
                    PrName = "iphone8",
                    Price = 35000,
                    PrSafetyStock = 60,
                    M_SmallClassification = sc[8],
                    PrModelNumber = "0801",
                    PrColor = "白",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[17],
                    PrName = "iphone9",
                    Price = 40000,
                    PrSafetyStock = 40,
                    M_SmallClassification = sc[8],
                    PrModelNumber = "0802",
                    PrColor = "赤",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[17],
                    PrName = "iphone10",
                    Price = 45000,
                    PrSafetyStock = 30,
                    M_SmallClassification = sc[8],
                    PrModelNumber = "0803",
                    PrColor = "青",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[17],
                    PrName = "iphone11",
                    Price = 50000,
                    PrSafetyStock = 20,
                    M_SmallClassification = sc[8],
                    PrModelNumber = "0804",
                    PrColor = "黄",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[17],
                    PrName = "iphone12",
                    Price = 55000,
                    PrSafetyStock = 15,
                    M_SmallClassification = sc[8],
                    PrModelNumber = "0805",
                    PrColor = "黒",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[17],
                    PrName = "iphone13",
                    Price = 60000,
                    PrSafetyStock = 10,
                    M_SmallClassification = sc[8],
                    PrModelNumber = "0806",
                    PrColor = "紫",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[17],
                    PrName = "iphoneSE",
                    Price = 30000,
                    PrSafetyStock = 60,
                    M_SmallClassification = sc[8],
                    PrModelNumber = "0807",
                    PrColor = "黒",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[17],
                    PrName = "iphoneSSS",
                    Price = 90000,
                    PrSafetyStock = 100,
                    M_SmallClassification = sc[8],
                    PrModelNumber = "0808",
                    PrColor = "虹",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンA",
                    Price = 40000,
                    PrSafetyStock = 40,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0901",
                    PrColor = "黒",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });


                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンB",
                    Price = 50000,
                    PrSafetyStock = 20,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0902",
                    PrColor = "金",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンC",
                    Price = 60000,
                    PrSafetyStock = 35,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0903",
                    PrColor = "青",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンD",
                    Price = 30000,
                    PrSafetyStock = 20,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0904",
                    PrColor = "赤",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンE",
                    Price = 35000,
                    PrSafetyStock = 15,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0904",
                    PrColor = "緑",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンF",
                    Price = 45000,
                    PrSafetyStock = 35,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0905",
                    PrColor = "黒",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンG",
                    Price = 55000,
                    PrSafetyStock = 15,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0906",
                    PrColor = "黒",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンH",
                    Price = 23000,
                    PrSafetyStock = 45,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0907",
                    PrColor = "白",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンI",
                    Price = 34000,
                    PrSafetyStock = 30,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0907",
                    PrColor = "白",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンJ",
                    Price = 42000,
                    PrSafetyStock = 20,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0908",
                    PrColor = "赤",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンK",
                    Price = 31000,
                    PrSafetyStock = 20,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0909",
                    PrColor = "赤",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンL",
                    Price = 25000,
                    PrSafetyStock = 20,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0910",
                    PrColor = "緑",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンM",
                    Price = 46000,
                    PrSafetyStock = 40,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0911",
                    PrColor = "緑",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンN",
                    Price = 31000,
                    PrSafetyStock = 35,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0912",
                    PrColor = "紫",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンO",
                    Price = 80000,
                    PrSafetyStock = 50,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0913",
                    PrColor = "紫",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });




                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンP",
                    Price = 12000,
                    PrSafetyStock = 30,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0914",
                    PrColor = "紫",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンQ",
                    Price = 6000,
                    PrSafetyStock = 20,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0915",
                    PrColor = "紫",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });



                pr.Add(new M_Product()
                {
                    M_Maker = ma[25],
                    PrName = "スマートフォンR",
                    Price = 90000,
                    PrSafetyStock = 45,
                    M_SmallClassification = sc[9],
                    PrModelNumber = "0916",
                    PrColor = "虹",
                    PrReleaseDate = new DateTime(2023, 1, 1),
                    PrFlag = 0,
                });
                context.M_Products.AddRange(pr);
                context.SaveChanges();
            }
            List<T_Stock> st = new List<T_Stock>();
            {
                st.Add(new T_Stock()
                {
                    M_Product = pr[0],
                    StQuantity = 10,
                    StFlag = 0,
                    StState = 1,
                    StHidden = null
                }); ;
                st.Add(new T_Stock()
                {
                    M_Product = pr[1],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[2],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[3],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[4],
                    StQuantity = 0,
                    StFlag = 0,
                    StState = 1,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[5],
                    StQuantity = 0,
                    StFlag = 0,
                    StState = 1,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[6],
                    StQuantity = 0,
                    StFlag = 0,
                    StState = 1,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[7],
                    StQuantity = 0,
                    StFlag = 0,
                    StState = 1,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[8],
                    StQuantity = 0,
                    StFlag = 0,
                    StState = 1,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[9],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[10],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[11],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[12],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[13],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[14],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[15],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[16],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[17],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[18],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[19],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[20],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[21],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[22],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[23],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[24],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[25],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[26],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[27],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[28],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[29],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[30],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[31],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[32],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[33],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[34],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[35],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[36],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[37],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[38],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[39],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[40],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[41],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[42],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[43],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                }) ;
                st.Add(new T_Stock()
                {
                    M_Product = pr[44],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[45],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[46],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[47],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[48],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[49],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[50],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[51],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[52],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[53],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[54],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[55],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[56],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[57],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[58],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[59],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[60],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[61],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[62],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[63],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[64],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[65],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[66],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[67],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[68],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[69],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[70],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[71],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[72],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[73],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[74],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[75],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[76],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[77],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[78],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[79],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[80],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[81],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[82],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[83],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[84],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[85],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[86],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[87],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[88],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[89],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[90],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[91],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[92],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[93],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[94],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[95],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[96],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[97],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[98],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[99],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[100],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[101],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[102],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[103],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[104],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[105],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[106],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[107],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[108],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[109],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[110],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[111],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[112],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                st.Add(new T_Stock()
                {
                    M_Product = pr[113],
                    StQuantity = 100,
                    StFlag = 0,
                    StState = 0,
                    StHidden = null
                });
                context.T_Stocks.AddRange(st);
                context.SaveChanges();
            }

            context.Dispose();


        }


    }
}
