using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;
namespace KK2.Model
{
    public static class DataWorker
    {
        private static string DateString(DateTime date)
        {
            return date.Year.ToString() + "-" + date.Month.ToString() + "-" + date.Day.ToString();
        }
        public static bool error;
        public static class UserDw
        {
            public static User thisUser = new User();
            //создать пользователя
            public static void CreateUser(string Name, string Sername, string Patroname,
                                            DateTime Birthday, int PhoneNumber, int PassportSeries,
                                            int PassportNumber, string Login, string Password)
            {
                thisUser.Name = Name;
                thisUser.Sername = Sername;
                thisUser.Patroname = Patroname;
                thisUser.Birthday = DateString(Birthday);
                thisUser.PhoneNumber = PhoneNumber;
                thisUser.PassportSeries = PassportSeries;
                thisUser.PassportNumber = PassportNumber;
                thisUser.Login = Login;
                thisUser.Password = Password;

                try
                {
                    DB.ConnectOpen();
                    string sql = $"INSERT INTO `user` (`name`, `sername`, `patroname`, `birthday`, `phone_number`," +
                        $" `passport_series`, `passport_number`, `login`, `password`) VALUES ('{Name}', '{Sername}', '{Patroname}', " +
                                    $"'{thisUser.Birthday}', '{PhoneNumber}', '{PassportSeries}', '{PassportNumber}', " +
                                    $"'{Login}', '{Password}');";
                    MySqlCommand dbCommand = new MySqlCommand(sql, DB.GetDbConnection);
                    if (dbCommand.ExecuteNonQuery() != 1)
                    {
                        error = true;
                    }
                    else
                    {
                        error = false;
                        MySqlCommand Command = new MySqlCommand($"SELECT `iduser` FROM `user` WHERE `login` = '{thisUser.Login}';", DB.GetDbConnection);
                        object result = Command.ExecuteScalar();
                        thisUser.Id = Convert.ToInt32(result);
                        DB.ConnectClose();
                    }
                }
                catch (Exception e)
                {
                    string a = e.Message;
                    error = true;
                }
            }
            //поиск пользователя
            public static void Find(string Login, string Password)
            {
                try
                {
                    DB.ConnectOpen();
                    string sql = $"SELECT `iduser`, `name`, `sername`, `patroname`, " +
                                    $"`birthday`, `phone_number`, `passport_series`, `passport_number`, " +
                                    $"`password`, `rielt` FROM `user` WHERE `login` = '{Login}' AND `password` = '{Password}';";
                    MySqlCommand dbCommand = new MySqlCommand(sql, DB.GetDbConnection);
                    MySqlDataReader reader = dbCommand.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        error = false;
                        thisUser.Id = Convert.ToInt32(reader[0]);
                        thisUser.Name = Convert.ToString(reader[1]);
                        thisUser.Sername = Convert.ToString(reader[2]);
                        thisUser.Patroname = Convert.ToString(reader[3]);
                        thisUser.Birthday = Convert.ToString(reader[4]);
                        thisUser.PhoneNumber = Convert.ToInt32(reader[5]);
                        thisUser.PassportSeries = Convert.ToInt32(reader[6]);
                        thisUser.PassportNumber = Convert.ToInt32(reader[7]);
                        thisUser.Login = Login;
                        thisUser.Password = Convert.ToString(reader.GetValue(8));
                        thisUser.Rielt = Convert.ToInt32(reader.GetValue(9));
                    }
                    else
                    {
                        error = true;
                    }
                    DB.ConnectClose();
                }
                catch
                {
                    error = true;
                }
            }

        }

        public static class Advt
        {
            public static Object thisAdvt;
    //Купить
            public static class Buy
            {
                public static List<AdvtBuy> Advts = new List<AdvtBuy>();
                //создать объявление
                public static void Create(int HausTypeId,
                                int MinFlor, int MaxFlor, int MinNumberRows,
                                int MaxNumberRows, int DistrictId, string Description, int MinPrice, int MaxPrice)
                {
                    try
                    {
                        error = false;
                        thisAdvt = new AdvtBuy
                        {
                            UserID = UserDw.thisUser.Id,
                            HausTypeId = HausTypeId,
                            MinFlor = MinFlor,
                            MaxFlor = MaxFlor,
                            MinNumberRows = MinNumberRows,
                            MaxNumberRows = MaxNumberRows,
                            DistrictId = DistrictId,
                            Description = Description,
                            MinPrice = MinPrice,
                            MaxPrice = MaxPrice
                        };
                        DB.ConnectOpen();
                        string sql = $"INSERT INTO `advt_buy` (`iduser`, `idhaus__type`, `min_floor`, " +
                                  $"`max_floor`, `min_n_rows`, `max_n_rows`, `idrayon`, " +
                                  $"`descrtiption`, `min_price`, `max_price`) VALUES('{UserDw.thisUser.Id}', " +
                                  $"'{HausTypeId}', '{MinFlor}', '{MaxFlor}', '{MinNumberRows}', " +
                                  $"'{MaxNumberRows}', '{DistrictId}', '{Description}', " +
                                  $"'{MinPrice}', '{MaxPrice}');";
                        MySqlCommand dbCommand = new MySqlCommand(sql, DB.GetDbConnection);
                        if (dbCommand.ExecuteNonQuery() != 1)
                        {
                            error = true;
                        }
                        else
                        {
                            error = false;
                        }
                        DB.ConnectClose();
                    }
                    catch
                    {
                        error = true;
                    }
                    
                }
                //получить инф-у об объявлении
                public static void Find(int UserId)
                {
                    DB.ConnectOpen();
                    string sql = $"SELECT `idadvt_buy`, `iduser` ,`idhaus__type`, `min_floor`, " +
                              $"`max_floor`, `min_n_rows`, `max_n_rows`, `idrayon`, " +
                              $"`descrtiption`, `min_price`, `max_price` FROM `advt_buy` WHERE `iduser` = '{UserId}';";
                    MySqlCommand dbCommand = new MySqlCommand(sql, DB.GetDbConnection);
                    MySqlDataReader reader = dbCommand.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                        Advts = dt.AsEnumerable().Select(se => new AdvtBuy()
                        {
                            Id = se.Field<int>("idadvt_buy"),
                            UserID = se.Field<int>("iduser"),
                            HausTypeId = se.Field<int>("idhaus__type"),
                            MinFlor = se.Field<int>("min_floor"),
                            MaxFlor = se.Field<int>("max_floor"),
                            MinNumberRows = se.Field<int>("min_n_rows"),
                            MaxNumberRows = se.Field<int>("max_n_rows"),
                            DistrictId = se.Field<int>("idrayon"),
                            Description = se.Field<string>("descrtiption"),
                            MinPrice = se.Field<int>("min_price"),
                            MaxPrice = se.Field<int>("max_price")
                        }).ToList();
                }
                //удалить объявление
                public static void Delete(int AdvtId)
                {
                    DB.ConnectOpen();
                    string sql = $"DELETE FROM `advt_buy` WHERE (`idadvt_buy` = '{AdvtId}');";
                    DB.ConnectClose();
                }
            }
            //Пррдать
            public static class Sell
            {
                public static List<AdvtSell> Advts = new List<AdvtSell>();
                //Создать объявление
                public static void Create(int HausTypeId,
                            int Floor, int NumberOfRooms, int SQ, string Adress,
                            int DistrictId, string Description, int Price)
                {
                    try
                    {
                        error = false;
                        thisAdvt = new AdvtSell
                        {
                            UserId = UserDw.thisUser.Id,
                            HausTypeId = HausTypeId,
                            Floor = Floor,
                            NumberOfRooms = NumberOfRooms,
                            SQ = SQ,
                            Adress = Adress,
                            DistrictId = DistrictId,
                            Description = Description,
                            Price = Price
                        };
                        DB.ConnectOpen();
                        string sql = $"INSERT INTO `advt_sell` (`iduser`, `idhaus_type`, " +
                            $"`floor`, `number_of_rooms`, `kv_m`, `adress`, `id_rayon`, " +
                            $"`description`, `price`) VALUES ('{UserDw.thisUser.Id}', '{HausTypeId}'," +
                            $" '{Floor}', '{NumberOfRooms}', '{SQ}', '{Adress}', '{DistrictId}', " +
                            $"'{Description}', '{Price}');";
                        MySqlCommand dbCommand = new MySqlCommand(sql, DB.GetDbConnection);
                        if (dbCommand.ExecuteNonQuery() != 1)
                        {
                            error = true;
                        }
                        else
                        {
                            error = false;
                        }
                        DB.ConnectClose();

                    }
                    catch (Exception e)
                    {
                        string a = e.Message;
                        error = true;
                    }
                }
                //Найти объявление
                public static void Find(int UserId)
                {
                    DB.ConnectOpen();
                    string sql = $"SELECT `idadvt_sell`, `iduser`, `idhaus_type`, `floor`, " +
                              $"`number_of_rooms`, `kv_m`, `adress`, `id_rayon`, " +
                              $"`description`, `price` FROM `advt_sell` WHERE `iduser` = '{UserId}';";
                    MySqlCommand dbCommand = new MySqlCommand(sql, DB.GetDbConnection);
                    MySqlDataReader reader = dbCommand.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    Advts = dt.AsEnumerable().Select(se => new AdvtSell()
                    {
                        Id = se.Field<int>("idadvt_sell"),
                        UserId = UserId,
                        HausTypeId = se.Field<int>("idhaus_type"),
                        Floor = se.Field<int>("floor"),
                        NumberOfRooms = se.Field<int>("number_of_rooms"),
                        SQ = se.Field<int>("kv_m"),
                        Adress = se.Field<string>("adress"),
                        DistrictId = se.Field<int>("id_rayon"),
                        Description = se.Field<string>("description"),
                        Price = se.Field<int>("price")
                    }).ToList();
                    DB.ConnectClose();
                }
                //Удалить объявление
                public static void Delete(int AdvtId)
                {
                    DB.ConnectOpen();
                    string sql = $"DELETE FROM `advt_sell` WHERE (`idadvt_sell` = '{AdvtId}');";
                    DB.ConnectClose();
                }
            }
            //Снять
            public static class Rent
            {
                public static List<AdvtRent> Advts = new List<AdvtRent>();
                //Создать объявление
                public static void Create(int HausTypeId,
                                    int MinFlor, int MaxFlor, int MinNumberRows,
                                    int MaxNumberRows, int DistrictId,DateTime MinArenda,
                                    DateTime MaxArenda, string Description, int MinPrice, int MaxPrice)
                {
                    try
                    {
                        error = false;
                        thisAdvt = new AdvtRent
                        {
                            UserId = UserDw.thisUser.Id,
                            HausTypeId = HausTypeId,
                            MinFlor = MinFlor,
                            MaxFlor = MaxFlor,
                            MinNumberRows = MinNumberRows,
                            MaxNumberRows = MaxNumberRows,
                            DistrictId = DistrictId,
                            Description = Description,
                            MinArenda = MinArenda,
                            MaxArenda = MaxArenda,
                            MinPrice = MinPrice,
                            MaxPrice = MaxPrice
                        };
                        DB.ConnectOpen();
                        string sql = $"INSERT INTO `advt_rent` (`iduser`, `idhaus_type`, `min_floor`, " +
                            $"`max_floor`, `min_n_rows`, `max_n_rows`, `idrayon`, `descrtiption`, `min_arenda`, " +
                            $"`max_arenda`, `min_price`, `max_price`) " +
                            $"VALUES ('{UserDw.thisUser.Id}', " +
                                    $"'{HausTypeId}', '{MinFlor}', '{MaxFlor}', '{MinNumberRows}', " +
                                    $"'{MaxNumberRows}', '{DistrictId}', '{Description}', " +
                                    $"'{DateString(MinArenda)}', '{DateString(MaxArenda)}'," +
                                    $"'{MinPrice}', '{MaxPrice}');";
                        MySqlCommand dbCommand = new MySqlCommand(sql, DB.GetDbConnection);
                        if (dbCommand.ExecuteNonQuery() != 1)
                        {
                            error = true;
                        }
                        else
                        {
                            error = false;
                        }
                        DB.ConnectClose();
                    }
                    catch(Exception e)
                    {
                        string a = e.Message;
                        error = true;
                    }

                }
                //получить инф-у об объявлении
                public static void Find(int UserId)
                {
                    DB.ConnectOpen();
                    string sql = $"SELECT `idadvt_rent`, `idhaus_type`, `min_floor`, " +
                            $"`max_floor`, `min_n_rows`, `max_n_rows`, `idrayon`, " +
                            $"`descrtiption`, `min_arenda`, `max_arenda`, `min_price`," +
                            $" `max_price` FROM `advt_rent` WHERE `iduser` = '{UserId}';";
                    MySqlCommand dbCommand = new MySqlCommand(sql, DB.GetDbConnection);
                    MySqlDataReader reader = dbCommand.ExecuteReader();
                    DataTable dt = new DataTable();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                        Advts = dt.AsEnumerable().Select(se => new AdvtRent()
                        {
                            Id = se.Field<int>("idadvt_rent"),
                            UserId = UserId,
                            HausTypeId = se.Field<int>("idhaus_type"),
                            MinFlor = se.Field<int>("min_floor"),
                            MaxFlor = se.Field<int>("max_floor"),
                            MinNumberRows = se.Field<int>("min_n_rows"),
                            MaxNumberRows = se.Field<int>("max_n_rows"),
                            DistrictId = se.Field<int>("idrayon"),
                            Description = se.Field<string>("descrtiption"),
                            MinArenda = se.Field<DateTime>("min_arenda"),
                            MaxArenda = se.Field<DateTime>("min_arenda"),
                            MinPrice = se.Field<int>("min_price"),
                            MaxPrice = se.Field<int>("max_price")
                        }).ToList();
                        DB.ConnectClose();
                    }
                    else
                    {
                        error = true;
                    }
                }
                //удалить объявление
                public static void Delete(int AdvtId)
                {
                    DB.ConnectOpen();
                    string sql = $"DELETE FROM `advt_rent` WHERE (`idadvt_rent` = '{AdvtId}');";
                    DB.ConnectClose();
                }
            }
    //Сдать
            public static class GetBy
            {
                public static List<AdvtGetby> Advts = new List<AdvtGetby>();
                public static void Create(int HausTypeId,
                        int Floor, int NumberOfRooms, int SQ, string Adress,
                        int DistrictId, string Description, DateTime MinArenda, DateTime MaxArenda,
                        int Price)
                {
                    try
                    {
                        error = false;
                        thisAdvt = new AdvtGetby
                        {
                            UserId = UserDw.thisUser.Id,
                            HausTypeId = HausTypeId,
                            Floor = Floor,
                            NumberOfRooms = NumberOfRooms,
                            SQ = SQ,
                            Adress = Adress,
                            DistrictId = DistrictId,
                            Description = Description,
                            MinArenda = MinArenda,
                            MaxArenda = MaxArenda,
                            Price = Price
                        };
                        DB.ConnectOpen();
                        string sql = $"INSERT INTO `advt_getby` " +
                            $"(`iduser`, `idhaus_type`, `floor`, `number_of_rooms`, `kv_m`, " +
                            $"`adress`, `id_rayon`, `min_arenda`, `max_arenda`, `description`, `price`) " +
                            $"VALUES ('{UserDw.thisUser.Id}', '{HausTypeId}', " +
                        $"'{Floor}', '{NumberOfRooms}', '{SQ}', '{Adress}', '{DistrictId}', " +
                        $"'{DateString(MinArenda)}', '{DateString(MaxArenda)}', " +
                        $"'{Description}', '{Price}');";
                        MySqlCommand dbCommand = new MySqlCommand(sql, DB.GetDbConnection);
                        if (dbCommand.ExecuteNonQuery() != 1)
                        {
                            error = true;
                        }
                        else
                        {
                            error = false;
                        }
                        DB.ConnectClose();
                    }
                    catch (Exception e)
                    {
                        string a = e.Message;
                        error = true;
                    }

                }
                //получить инф-у об объявлении
                public static void Find(int UserId)
                {
                    DB.ConnectOpen();
                    string sql = $"SELECT `idadvt_getby`, `idhaus_type`, `floor`, `number_of_rooms`, " +
                            $"`kv_m`, `adress`, `id_rayon`, `min_arenda`, `max_arenda`, " +
                            $"`description`, `price` FROM `advt_getby` WHERE `iduser` = '{UserId}';";
                    MySqlCommand dbCommand = new MySqlCommand(sql, DB.GetDbConnection);
                    MySqlDataReader reader = dbCommand.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    Advts = dt.AsEnumerable().Select(se => new AdvtGetby()
                    {
                        Id = se.Field<int>("idadvt_getby"),
                        UserId = UserId,
                        HausTypeId = se.Field<int>("idhaus_type"),
                        Floor = se.Field<int>("floor"),
                        NumberOfRooms = se.Field<int>("number_of_rooms"),
                        SQ = se.Field<int>("kv_m"),
                        Adress = se.Field<string>("adress"),
                        MinArenda = se.Field<DateTime>("min_arenda"),
                        MaxArenda = se.Field<DateTime>("max_arenda"),
                        DistrictId = se.Field<int>("id_rayon"),
                        Description = se.Field<string>("description"),
                    }).ToList();
                    DB.ConnectClose();
                }
                //удалить объявление
                public static void Delete(int AdvtId)
                {
                    DB.ConnectOpen();
                    string sql = $"DELETE FROM `advt_getby` WHERE (`idadvt_getby` = '{AdvtId}');";
                    DB.ConnectClose();
                }
            }
        }




        //создать варианты

        //создать договор

        //удалить вариант
    }
}
