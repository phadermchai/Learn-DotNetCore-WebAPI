using System;
using System.Data;
using MySql.Data.MySqlClient;
using WebApi.Model;

namespace WebApi.Service
{
    public class PostService
    {

        public static Response GetResponseData(JsonRegisterInfo json_info){
             Response res = new Response () {
                message = "ok",
                data = { },
                resp_droplead = {}
            };

            try{
                var db = new ConnectMySQL();
                string sql = $"INSERT INTO users(username, password, email) VALUES ('{json_info.username}','{json_info.password}', '{json_info.email}')";
                
                db.executeQuery(sql);

            }catch(Exception ex){
                res.message = ex.Message;
                res.data = json_info;
            }

            return res;
        }

    }
} 