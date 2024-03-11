using WebApplication3.Models;
using WebApplication3.Models.roue;
using WebApplication3.Data.enums;
using WebApplication3.Models.Produits;

namespace WebApplication3.Data
{
    public class AppDbInicialisateur
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                //Acteur
                if (!context.Nombres.Any())
                {
                    context.Nombres.AddRange(new List<NombreModel>()
                    {
                        new NombreModel()
                        {
                            Nombre=1
                        },
                        new NombreModel()
                        {
                            Nombre=1
                        },
                        new NombreModel()
                        {
                            Nombre=1
                        },
                    });
                    context.SaveChanges();
                }

                //roue
                if (!context.roue.Any())
                {
                    context.roue.AddRange(new List<Roue>()
                    {
                        new Roue()
                        {
                            image="https://southcentralus1-mediap.svc.ms/transform/thumbnail?provider=spo&farmid=193369&inputFormat=png&cs=MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0fFNQTw&docid=https%3A%2F%2Fmy.microsoftpersonalcontent.com%2F_api%2Fv2.0%2Fdrives%2Fb!Dd2mzAdLi0G2xGom4zVJQeNrg9cYKhBLu8IomtDQ3tAsg8k-P8mbSJBC4INGQHX_%2Fitems%2F01NIM3TXO3EVQ2S73RQNHIGATAQF3FTHJA%3Ftempauth%3DeyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbXkubWljcm9zb2Z0cGVyc29uYWxjb250ZW50LmNvbUA5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJpc3MiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAiLCJuYmYiOiIxNzA5NDEzMjAwIiwiZXhwIjoiMTcwOTQzNDgwMCIsImVuZHBvaW50dXJsIjoiWHBha2cxeEQzK0dUWlUrMFp4MWdoVjZQU1J3anVaT05hUjRxQ2N3TVVYND0iLCJlbmRwb2ludHVybExlbmd0aCI6IjE2NCIsImlzbG9vcGJhY2siOiJUcnVlIiwidmVyIjoiaGFzaGVkcHJvb2Z0b2tlbiIsInNpdGVpZCI6IlkyTmhObVJrTUdRdE5HSXdOeTAwTVRoaUxXSTJZelF0Tm1FeU5tVXpNelUwT1RReCIsImFwcF9kaXNwbGF5bmFtZSI6IkNvbnN1bWVyIEFwcDogMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0IiwiYXBwaWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwNDgxNzEwYTQiLCJ0aWQiOiI5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJ1cG4iOiJrYW5hbWF4QG91dGxvb2suZnIiLCJwdWlkIjoiMDAwMzAwMDA1M0I1NkQwQSIsImNhY2hla2V5IjoiMGguZnxtZW1iZXJzaGlwfDAwMDMwMDAwNTNiNTZkMGFAbGl2ZS5jb20iLCJzY3AiOiJhbGxzaXRlcy5mdWxsY29udHJvbCIsInNpZCI6IjE1MDUwNjU2Mzk5NTMyMTcwMTgzIiwidHQiOiIyIiwiaXBhZGRyIjoiNDEuMjAyLjIxOS43MyJ9.O0Z0QGb0lqALu5d_5zbSGPWdUL8qJUMCAVBMjSTHl8Y%26version%3DPublished&cb=63844589823&encodeFailures=1&width=235&height=301",
                            prix=100,
                            nombre=1
                        },
                        new Roue()
                        {
                            image="https://southcentralus1-mediap.svc.ms/transform/thumbnail?provider=spo&farmid=193369&inputFormat=png&cs=MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0fFNQTw&docid=https%3A%2F%2Fmy.microsoftpersonalcontent.com%2F_api%2Fv2.0%2Fdrives%2Fb!Dd2mzAdLi0G2xGom4zVJQeNrg9cYKhBLu8IomtDQ3tAsg8k-P8mbSJBC4INGQHX_%2Fitems%2F01NIM3TXNIZU7CYKX5DZGZ2K2CRITSUZ55%3Ftempauth%3DeyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbXkubWljcm9zb2Z0cGVyc29uYWxjb250ZW50LmNvbUA5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJpc3MiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAiLCJuYmYiOiIxNzA5NDEzMjAwIiwiZXhwIjoiMTcwOTQzNDgwMCIsImVuZHBvaW50dXJsIjoiNVJrTTFsai83V2NDUHNsNjhFNXdyTXhjanlTMCtOYjZ3ZkR2bW9nVm5lOD0iLCJlbmRwb2ludHVybExlbmd0aCI6IjE2NCIsImlzbG9vcGJhY2siOiJUcnVlIiwidmVyIjoiaGFzaGVkcHJvb2Z0b2tlbiIsInNpdGVpZCI6IlkyTmhObVJrTUdRdE5HSXdOeTAwTVRoaUxXSTJZelF0Tm1FeU5tVXpNelUwT1RReCIsImFwcF9kaXNwbGF5bmFtZSI6IkNvbnN1bWVyIEFwcDogMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0IiwiYXBwaWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwNDgxNzEwYTQiLCJ0aWQiOiI5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJ1cG4iOiJrYW5hbWF4QG91dGxvb2suZnIiLCJwdWlkIjoiMDAwMzAwMDA1M0I1NkQwQSIsImNhY2hla2V5IjoiMGguZnxtZW1iZXJzaGlwfDAwMDMwMDAwNTNiNTZkMGFAbGl2ZS5jb20iLCJzY3AiOiJhbGxzaXRlcy5mdWxsY29udHJvbCIsInNpZCI6IjE1MDUwNjU2Mzk5NTMyMTcwMTgzIiwidHQiOiIyIiwiaXBhZGRyIjoiNDEuMjAyLjIxOS43MyJ9.z5i7zL3BETXnYa09ubEjz7pgLDyuxjqwpfgeSlWVfvk%26version%3DPublished&cb=63844589979&encodeFailures=1&width=497&height=630",
                            prix=100,
                            nombre=1
                        },
                        new Roue()
                        {
                            image = "https://southcentralus1-mediap.svc.ms/transform/thumbnail?provider=spo&farmid=193369&inputFormat=png&cs=MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0fFNQTw&docid=https%3A%2F%2Fmy.microsoftpersonalcontent.com%2F_api%2Fv2.0%2Fdrives%2Fb!Dd2mzAdLi0G2xGom4zVJQeNrg9cYKhBLu8IomtDQ3tAsg8k-P8mbSJBC4INGQHX_%2Fitems%2F01NIM3TXOBDLF5CYC4HRFKMA7PKP6TZXOP%3Ftempauth%3DeyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbXkubWljcm9zb2Z0cGVyc29uYWxjb250ZW50LmNvbUA5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJpc3MiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAiLCJuYmYiOiIxNzA5NDEzMjAwIiwiZXhwIjoiMTcwOTQzNDgwMCIsImVuZHBvaW50dXJsIjoiT1p3YUtacUcyNVAxYTBJamJBTHVyOTl5UW1HNEZKZzlPMHBETXNpdHVIVT0iLCJlbmRwb2ludHVybExlbmd0aCI6IjE2NCIsImlzbG9vcGJhY2siOiJUcnVlIiwidmVyIjoiaGFzaGVkcHJvb2Z0b2tlbiIsInNpdGVpZCI6IlkyTmhObVJrTUdRdE5HSXdOeTAwTVRoaUxXSTJZelF0Tm1FeU5tVXpNelUwT1RReCIsImFwcF9kaXNwbGF5bmFtZSI6IkNvbnN1bWVyIEFwcDogMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0IiwiYXBwaWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwNDgxNzEwYTQiLCJ0aWQiOiI5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJ1cG4iOiJrYW5hbWF4QG91dGxvb2suZnIiLCJwdWlkIjoiMDAwMzAwMDA1M0I1NkQwQSIsImNhY2hla2V5IjoiMGguZnxtZW1iZXJzaGlwfDAwMDMwMDAwNTNiNTZkMGFAbGl2ZS5jb20iLCJzY3AiOiJhbGxzaXRlcy5mdWxsY29udHJvbCIsInNpZCI6IjE1MDUwNjU2Mzk5NTMyMTcwMTgzIiwidHQiOiIyIiwiaXBhZGRyIjoiNDEuMjAyLjIxOS43MyJ9.8JzOykB4tmq-2WC_zSoUFrXeebR5SvXuZ0WPwhDyDM0%26version%3DPublished&cb=63844590069&encodeFailures=1&width=498&height=630",
                            prix=100,
                            nombre=1
                        },
                        new Roue()
                        {
                            image = "https://southcentralus1-mediap.svc.ms/transform/thumbnail?provider=spo&farmid=193369&inputFormat=png&cs=MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0fFNQTw&docid=https%3A%2F%2Fmy.microsoftpersonalcontent.com%2F_api%2Fv2.0%2Fdrives%2Fb!Dd2mzAdLi0G2xGom4zVJQeNrg9cYKhBLu8IomtDQ3tAsg8k-P8mbSJBC4INGQHX_%2Fitems%2F01NIM3TXOWWTZ7K57HOJBKJUPPF3IKHNUP%3Ftempauth%3DeyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbXkubWljcm9zb2Z0cGVyc29uYWxjb250ZW50LmNvbUA5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJpc3MiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAiLCJuYmYiOiIxNzA5NDEzMjAwIiwiZXhwIjoiMTcwOTQzNDgwMCIsImVuZHBvaW50dXJsIjoiVjVBdE5RSDBqUVJjTWV5alFCb09nTkdncG9SSkpJdUNHOHVWTjZLSG1ORT0iLCJlbmRwb2ludHVybExlbmd0aCI6IjE2NCIsImlzbG9vcGJhY2siOiJUcnVlIiwidmVyIjoiaGFzaGVkcHJvb2Z0b2tlbiIsInNpdGVpZCI6IlkyTmhObVJrTUdRdE5HSXdOeTAwTVRoaUxXSTJZelF0Tm1FeU5tVXpNelUwT1RReCIsImFwcF9kaXNwbGF5bmFtZSI6IkNvbnN1bWVyIEFwcDogMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0IiwiYXBwaWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwNDgxNzEwYTQiLCJ0aWQiOiI5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJ1cG4iOiJrYW5hbWF4QG91dGxvb2suZnIiLCJwdWlkIjoiMDAwMzAwMDA1M0I1NkQwQSIsImNhY2hla2V5IjoiMGguZnxtZW1iZXJzaGlwfDAwMDMwMDAwNTNiNTZkMGFAbGl2ZS5jb20iLCJzY3AiOiJhbGxzaXRlcy5mdWxsY29udHJvbCIsInNpZCI6IjE1MDUwNjU2Mzk5NTMyMTcwMTgzIiwidHQiOiIyIiwiaXBhZGRyIjoiNDEuMjAyLjIxOS43MyJ9.Y2jyAzvyF-7IiDzYpAIXpWvONoRnGWrCPwcl61xWO30%26version%3DPublished&cb=63844591489&encodeFailures=1&width=255&height=336",
                            prix=100,
                            nombre=1
                        },
                    });
                    context.SaveChanges();
                }
                //Gentes
                if (!context.gentes.Any())
                {
                    context.gentes.AddRange(new List<Gentes>()
                    {
                        new Gentes()
                        {
                            image="https://southcentralus1-mediap.svc.ms/transform/thumbnail?provider=spo&farmid=193369&inputFormat=png&cs=MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0fFNQTw&docid=https%3A%2F%2Fmy.microsoftpersonalcontent.com%2F_api%2Fv2.0%2Fdrives%2Fb!Dd2mzAdLi0G2xGom4zVJQeNrg9cYKhBLu8IomtDQ3tAsg8k-P8mbSJBC4INGQHX_%2Fitems%2F01NIM3TXOAAWSXRPFYHBGLXPJGCA6G54KG%3Ftempauth%3DeyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbXkubWljcm9zb2Z0cGVyc29uYWxjb250ZW50LmNvbUA5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJpc3MiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAiLCJuYmYiOiIxNzA5NDEzMjAwIiwiZXhwIjoiMTcwOTQzNDgwMCIsImVuZHBvaW50dXJsIjoiaGU3bTBnajdWWnZxa3AzcjhhVWVyK3RBNDM5dWs4aFRCdGc1WEdXcFhsUT0iLCJlbmRwb2ludHVybExlbmd0aCI6IjE2NCIsImlzbG9vcGJhY2siOiJUcnVlIiwidmVyIjoiaGFzaGVkcHJvb2Z0b2tlbiIsInNpdGVpZCI6IlkyTmhObVJrTUdRdE5HSXdOeTAwTVRoaUxXSTJZelF0Tm1FeU5tVXpNelUwT1RReCIsImFwcF9kaXNwbGF5bmFtZSI6IkNvbnN1bWVyIEFwcDogMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0IiwiYXBwaWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwNDgxNzEwYTQiLCJ0aWQiOiI5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJ1cG4iOiJrYW5hbWF4QG91dGxvb2suZnIiLCJwdWlkIjoiMDAwMzAwMDA1M0I1NkQwQSIsImNhY2hla2V5IjoiMGguZnxtZW1iZXJzaGlwfDAwMDMwMDAwNTNiNTZkMGFAbGl2ZS5jb20iLCJzY3AiOiJhbGxzaXRlcy5mdWxsY29udHJvbCIsInNpZCI6IjE1MDUwNjU2Mzk5NTMyMTcwMTgzIiwidHQiOiIyIiwiaXBhZGRyIjoiNDEuMjAyLjIxOS43MyJ9.h1vqjiK1kTIqQq8Z95eLSngDOuu3ciAANaGgpaiScCU%26version%3DPublished&cb=63844590299&encodeFailures=1&width=528&height=521",
                            prix=100,
                            nombre=1
                        },
                        new Gentes()
                        {
                            image="https://southcentralus1-mediap.svc.ms/transform/thumbnail?provider=spo&farmid=193369&inputFormat=png&cs=MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0fFNQTw&docid=https%3A%2F%2Fmy.microsoftpersonalcontent.com%2F_api%2Fv2.0%2Fdrives%2Fb!Dd2mzAdLi0G2xGom4zVJQeNrg9cYKhBLu8IomtDQ3tAsg8k-P8mbSJBC4INGQHX_%2Fitems%2F01NIM3TXOH2M6UFM4FIZBJGDHL43UBAH2D%3Ftempauth%3DeyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbXkubWljcm9zb2Z0cGVyc29uYWxjb250ZW50LmNvbUA5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJpc3MiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAiLCJuYmYiOiIxNzA5NDEzMjAwIiwiZXhwIjoiMTcwOTQzNDgwMCIsImVuZHBvaW50dXJsIjoibFU4OTZ4WW1UTkwzQUF5clpsNmZua2JNL2grVDQwaURkVlZMb2Q4bUgxdz0iLCJlbmRwb2ludHVybExlbmd0aCI6IjE2NCIsImlzbG9vcGJhY2siOiJUcnVlIiwidmVyIjoiaGFzaGVkcHJvb2Z0b2tlbiIsInNpdGVpZCI6IlkyTmhObVJrTUdRdE5HSXdOeTAwTVRoaUxXSTJZelF0Tm1FeU5tVXpNelUwT1RReCIsImFwcF9kaXNwbGF5bmFtZSI6IkNvbnN1bWVyIEFwcDogMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0IiwiYXBwaWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwNDgxNzEwYTQiLCJ0aWQiOiI5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJ1cG4iOiJrYW5hbWF4QG91dGxvb2suZnIiLCJwdWlkIjoiMDAwMzAwMDA1M0I1NkQwQSIsImNhY2hla2V5IjoiMGguZnxtZW1iZXJzaGlwfDAwMDMwMDAwNTNiNTZkMGFAbGl2ZS5jb20iLCJzY3AiOiJhbGxzaXRlcy5mdWxsY29udHJvbCIsInNpZCI6IjE1MDUwNjU2Mzk5NTMyMTcwMTgzIiwidHQiOiIyIiwiaXBhZGRyIjoiNDEuMjAyLjIxOS43MyJ9.U_8QHwQYH_nbKpRk18VZVzvjaQuF0ENItGybrxbtbQQ%26version%3DPublished&cb=63844590581&encodeFailures=1&width=477&height=441",
                            prix=100,
                            nombre=1
                        },
                        new Gentes()
                        {
                            image = "https://southcentralus1-mediap.svc.ms/transform/thumbnail?provider=spo&farmid=193369&inputFormat=png&cs=MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0fFNQTw&docid=https%3A%2F%2Fmy.microsoftpersonalcontent.com%2F_api%2Fv2.0%2Fdrives%2Fb!Dd2mzAdLi0G2xGom4zVJQeNrg9cYKhBLu8IomtDQ3tAsg8k-P8mbSJBC4INGQHX_%2Fitems%2F01NIM3TXJZR3I42B3XBNHLRI3URO5Y7FLQ%3Ftempauth%3DeyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbXkubWljcm9zb2Z0cGVyc29uYWxjb250ZW50LmNvbUA5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJpc3MiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAiLCJuYmYiOiIxNzA5NDEzMjAwIiwiZXhwIjoiMTcwOTQzNDgwMCIsImVuZHBvaW50dXJsIjoiQUhzNmlHMERsa0pyVGp2aitYRng1OWV2bzVMS002Wmp5NnltM3pmWFpiRT0iLCJlbmRwb2ludHVybExlbmd0aCI6IjE2NCIsImlzbG9vcGJhY2siOiJUcnVlIiwidmVyIjoiaGFzaGVkcHJvb2Z0b2tlbiIsInNpdGVpZCI6IlkyTmhObVJrTUdRdE5HSXdOeTAwTVRoaUxXSTJZelF0Tm1FeU5tVXpNelUwT1RReCIsImFwcF9kaXNwbGF5bmFtZSI6IkNvbnN1bWVyIEFwcDogMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0IiwiYXBwaWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwNDgxNzEwYTQiLCJ0aWQiOiI5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJ1cG4iOiJrYW5hbWF4QG91dGxvb2suZnIiLCJwdWlkIjoiMDAwMzAwMDA1M0I1NkQwQSIsImNhY2hla2V5IjoiMGguZnxtZW1iZXJzaGlwfDAwMDMwMDAwNTNiNTZkMGFAbGl2ZS5jb20iLCJzY3AiOiJhbGxzaXRlcy5mdWxsY29udHJvbCIsInNpZCI6IjE1MDUwNjU2Mzk5NTMyMTcwMTgzIiwidHQiOiIyIiwiaXBhZGRyIjoiNDEuMjAyLjIxOS43MyJ9.bbB8YJeseqN3IMAy2tgMMRMiiAQZwyrJCP3YyXDF9E4%26version%3DPublished&cb=63844590760&encodeFailures=1&width=411&height=394",
                            prix=100,
                            nombre=1
                        },
                        new Gentes()
                        {
                            image = "https://southcentralus1-mediap.svc.ms/transform/thumbnail?provider=spo&farmid=193369&inputFormat=png&cs=MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0fFNQTw&docid=https%3A%2F%2Fmy.microsoftpersonalcontent.com%2F_api%2Fv2.0%2Fdrives%2Fb!Dd2mzAdLi0G2xGom4zVJQeNrg9cYKhBLu8IomtDQ3tAsg8k-P8mbSJBC4INGQHX_%2Fitems%2F01NIM3TXMNLOLBGAWDMZEL4NRKLAXI5X3J%3Ftempauth%3DeyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbXkubWljcm9zb2Z0cGVyc29uYWxjb250ZW50LmNvbUA5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJpc3MiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAiLCJuYmYiOiIxNzA5NDEzMjAwIiwiZXhwIjoiMTcwOTQzNDgwMCIsImVuZHBvaW50dXJsIjoiWUNNSEFWTVM3N0t4dmlGQVZueW5YbG1ldEhqUUxCdGxXNE05QzNyVFFYST0iLCJlbmRwb2ludHVybExlbmd0aCI6IjE2NCIsImlzbG9vcGJhY2siOiJUcnVlIiwidmVyIjoiaGFzaGVkcHJvb2Z0b2tlbiIsInNpdGVpZCI6IlkyTmhObVJrTUdRdE5HSXdOeTAwTVRoaUxXSTJZelF0Tm1FeU5tVXpNelUwT1RReCIsImFwcF9kaXNwbGF5bmFtZSI6IkNvbnN1bWVyIEFwcDogMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0IiwiYXBwaWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwNDgxNzEwYTQiLCJ0aWQiOiI5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJ1cG4iOiJrYW5hbWF4QG91dGxvb2suZnIiLCJwdWlkIjoiMDAwMzAwMDA1M0I1NkQwQSIsImNhY2hla2V5IjoiMGguZnxtZW1iZXJzaGlwfDAwMDMwMDAwNTNiNTZkMGFAbGl2ZS5jb20iLCJzY3AiOiJhbGxzaXRlcy5mdWxsY29udHJvbCIsInNpZCI6IjE1MDUwNjU2Mzk5NTMyMTcwMTgzIiwidHQiOiIyIiwiaXBhZGRyIjoiNDEuMjAyLjIxOS43MyJ9.MJQyzE-W_zJGEqOkVD8ifjVuN5eIR-KJse7FdWm4Xr8%26version%3DPublished&cb=63844591381&encodeFailures=1&width=556&height=514",
                            prix=100,
                            nombre=1
                        },
                    });
                    context.SaveChanges();
                }
                //Pneus
                if (!context.pneus.Any())
                {
                    context.pneus.AddRange(new List<Pneus>()
                    {
                        new Pneus()
                        {
                            image="https://southcentralus1-mediap.svc.ms/transform/thumbnail?provider=spo&farmid=193369&inputFormat=png&cs=MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0fFNQTw&docid=https%3A%2F%2Fmy.microsoftpersonalcontent.com%2F_api%2Fv2.0%2Fdrives%2Fb!Dd2mzAdLi0G2xGom4zVJQeNrg9cYKhBLu8IomtDQ3tAsg8k-P8mbSJBC4INGQHX_%2Fitems%2F01NIM3TXI62ZXZMHDELNFYNQESMOV5EYKV%3Ftempauth%3DeyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbXkubWljcm9zb2Z0cGVyc29uYWxjb250ZW50LmNvbUA5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJpc3MiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAiLCJuYmYiOiIxNzA5NDEzMjAwIiwiZXhwIjoiMTcwOTQzNDgwMCIsImVuZHBvaW50dXJsIjoiNmJyR3pYamx3SmsrTm96VkNGYWR4bWhEQUZ6K2lKUGhVdCt2MzIzQ2FTRT0iLCJlbmRwb2ludHVybExlbmd0aCI6IjE2NCIsImlzbG9vcGJhY2siOiJUcnVlIiwidmVyIjoiaGFzaGVkcHJvb2Z0b2tlbiIsInNpdGVpZCI6IlkyTmhObVJrTUdRdE5HSXdOeTAwTVRoaUxXSTJZelF0Tm1FeU5tVXpNelUwT1RReCIsImFwcF9kaXNwbGF5bmFtZSI6IkNvbnN1bWVyIEFwcDogMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0IiwiYXBwaWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwNDgxNzEwYTQiLCJ0aWQiOiI5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJ1cG4iOiJrYW5hbWF4QG91dGxvb2suZnIiLCJwdWlkIjoiMDAwMzAwMDA1M0I1NkQwQSIsImNhY2hla2V5IjoiMGguZnxtZW1iZXJzaGlwfDAwMDMwMDAwNTNiNTZkMGFAbGl2ZS5jb20iLCJzY3AiOiJhbGxzaXRlcy5mdWxsY29udHJvbCIsInNpZCI6IjE1MDUwNjU2Mzk5NTMyMTcwMTgzIiwidHQiOiIyIiwiaXBhZGRyIjoiNDEuMjAyLjIxOS43MyJ9.HZ7yagbY88vi3uzCj7YGA_D8vIW1KNkBZBM6U37SJRY%26version%3DPublished&cb=63844591663&encodeFailures=1&width=419&height=630",
                            prix=100,
                            nombre=1
                        },
                        new Pneus()
                        {
                            image="https://southcentralus1-mediap.svc.ms/transform/thumbnail?provider=spo&farmid=193369&inputFormat=png&cs=MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0fFNQTw&docid=https%3A%2F%2Fmy.microsoftpersonalcontent.com%2F_api%2Fv2.0%2Fdrives%2Fb!Dd2mzAdLi0G2xGom4zVJQeNrg9cYKhBLu8IomtDQ3tAsg8k-P8mbSJBC4INGQHX_%2Fitems%2F01NIM3TXMDVC4H2BRSZZB2V7ADKYB4KF7E%3Ftempauth%3DeyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbXkubWljcm9zb2Z0cGVyc29uYWxjb250ZW50LmNvbUA5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJpc3MiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAiLCJuYmYiOiIxNzA5NDEzMjAwIiwiZXhwIjoiMTcwOTQzNDgwMCIsImVuZHBvaW50dXJsIjoiMFl3Y3FhckJ0SWliL1dveWtpNzloaVdkWGlQandENXVNd3dkamZiUHdBMD0iLCJlbmRwb2ludHVybExlbmd0aCI6IjE2NCIsImlzbG9vcGJhY2siOiJUcnVlIiwidmVyIjoiaGFzaGVkcHJvb2Z0b2tlbiIsInNpdGVpZCI6IlkyTmhObVJrTUdRdE5HSXdOeTAwTVRoaUxXSTJZelF0Tm1FeU5tVXpNelUwT1RReCIsImFwcF9kaXNwbGF5bmFtZSI6IkNvbnN1bWVyIEFwcDogMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0IiwiYXBwaWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwNDgxNzEwYTQiLCJ0aWQiOiI5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJ1cG4iOiJrYW5hbWF4QG91dGxvb2suZnIiLCJwdWlkIjoiMDAwMzAwMDA1M0I1NkQwQSIsImNhY2hla2V5IjoiMGguZnxtZW1iZXJzaGlwfDAwMDMwMDAwNTNiNTZkMGFAbGl2ZS5jb20iLCJzY3AiOiJhbGxzaXRlcy5mdWxsY29udHJvbCIsInNpZCI6IjE1MDUwNjU2Mzk5NTMyMTcwMTgzIiwidHQiOiIyIiwiaXBhZGRyIjoiNDEuMjAyLjIxOS43MyJ9.93g95E-gaEsjGYi4_3-jAo9_qCSeqE_OJwiKrO_6z-M%26version%3DPublished&cb=63844591745&encodeFailures=1&width=230&height=353",
                            prix=100,
                            nombre=1
                        },
                        new Pneus()
                        {
                            image = "https://southcentralus1-mediap.svc.ms/transform/thumbnail?provider=spo&farmid=193369&inputFormat=png&cs=MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0fFNQTw&docid=https%3A%2F%2Fmy.microsoftpersonalcontent.com%2F_api%2Fv2.0%2Fdrives%2Fb!Dd2mzAdLi0G2xGom4zVJQeNrg9cYKhBLu8IomtDQ3tAsg8k-P8mbSJBC4INGQHX_%2Fitems%2F01NIM3TXN4TBGWPLEVN5F2FAG2V7YG7MCP%3Ftempauth%3DeyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbXkubWljcm9zb2Z0cGVyc29uYWxjb250ZW50LmNvbUA5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJpc3MiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAiLCJuYmYiOiIxNzA5NDEzMjAwIiwiZXhwIjoiMTcwOTQzNDgwMCIsImVuZHBvaW50dXJsIjoiSDBhTnU4M1V2OW03aTBlWTl5ZUo2WXFycC9vSnd5elhWSU9GbUt2V1ZSdz0iLCJlbmRwb2ludHVybExlbmd0aCI6IjE2NCIsImlzbG9vcGJhY2siOiJUcnVlIiwidmVyIjoiaGFzaGVkcHJvb2Z0b2tlbiIsInNpdGVpZCI6IlkyTmhObVJrTUdRdE5HSXdOeTAwTVRoaUxXSTJZelF0Tm1FeU5tVXpNelUwT1RReCIsImFwcF9kaXNwbGF5bmFtZSI6IkNvbnN1bWVyIEFwcDogMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0IiwiYXBwaWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwNDgxNzEwYTQiLCJ0aWQiOiI5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJ1cG4iOiJrYW5hbWF4QG91dGxvb2suZnIiLCJwdWlkIjoiMDAwMzAwMDA1M0I1NkQwQSIsImNhY2hla2V5IjoiMGguZnxtZW1iZXJzaGlwfDAwMDMwMDAwNTNiNTZkMGFAbGl2ZS5jb20iLCJzY3AiOiJhbGxzaXRlcy5mdWxsY29udHJvbCIsInNpZCI6IjE1MDUwNjU2Mzk5NTMyMTcwMTgzIiwidHQiOiIyIiwiaXBhZGRyIjoiNDEuMjAyLjIxOS43MyJ9.cPMKqq8PDZ4jGceDnisCYuI3yXgF56Oa92rI-o4Lpdg%26version%3DPublished&cb=63844591793&encodeFailures=1&width=454&height=630",
                            prix=100,
                            nombre=1
                        },
                        new Pneus()
                        {
                            image = "https://southcentralus1-mediap.svc.ms/transform/thumbnail?provider=spo&farmid=193369&inputFormat=png&cs=MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0fFNQTw&docid=https%3A%2F%2Fmy.microsoftpersonalcontent.com%2F_api%2Fv2.0%2Fdrives%2Fb!Dd2mzAdLi0G2xGom4zVJQeNrg9cYKhBLu8IomtDQ3tAsg8k-P8mbSJBC4INGQHX_%2Fitems%2F01NIM3TXLVW2RLVT74R5AIZUBGQSJJYH2M%3Ftempauth%3DeyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbXkubWljcm9zb2Z0cGVyc29uYWxjb250ZW50LmNvbUA5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJpc3MiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAiLCJuYmYiOiIxNzA5NDEzMjAwIiwiZXhwIjoiMTcwOTQzNDgwMCIsImVuZHBvaW50dXJsIjoiQjBScWZhM3RrK0JIdzJWNWNDRlowOHN5amVKc08xYVFPS2NKM0ExTHZZMD0iLCJlbmRwb2ludHVybExlbmd0aCI6IjE2NCIsImlzbG9vcGJhY2siOiJUcnVlIiwidmVyIjoiaGFzaGVkcHJvb2Z0b2tlbiIsInNpdGVpZCI6IlkyTmhObVJrTUdRdE5HSXdOeTAwTVRoaUxXSTJZelF0Tm1FeU5tVXpNelUwT1RReCIsImFwcF9kaXNwbGF5bmFtZSI6IkNvbnN1bWVyIEFwcDogMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0IiwiYXBwaWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwNDgxNzEwYTQiLCJ0aWQiOiI5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJ1cG4iOiJrYW5hbWF4QG91dGxvb2suZnIiLCJwdWlkIjoiMDAwMzAwMDA1M0I1NkQwQSIsImNhY2hla2V5IjoiMGguZnxtZW1iZXJzaGlwfDAwMDMwMDAwNTNiNTZkMGFAbGl2ZS5jb20iLCJzY3AiOiJhbGxzaXRlcy5mdWxsY29udHJvbCIsInNpZCI6IjE1MDUwNjU2Mzk5NTMyMTcwMTgzIiwidHQiOiIyIiwiaXBhZGRyIjoiNDEuMjAyLjIxOS43MyJ9.XdF-MJw3Ic38wy80X68BxNv1nnpOLtGk92E3AiloWzY%26version%3DPublished&cb=63844591880&encodeFailures=1&width=217&height=259",
                            prix=100,
                            nombre=1
                        },
                    });
                    context.SaveChanges();
                }
                //MainsOeuvre
                if (!context.mainsOeuvres.Any())
                {
                    context.mainsOeuvres.AddRange(new List<MainsOeuvre>()
                    {
                        new MainsOeuvre()
                        {
                            image="https://southcentralus1-mediap.svc.ms/transform/thumbnail?provider=spo&farmid=193369&inputFormat=png&cs=MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0fFNQTw&docid=https%3A%2F%2Fmy.microsoftpersonalcontent.com%2F_api%2Fv2.0%2Fdrives%2Fb!Dd2mzAdLi0G2xGom4zVJQeNrg9cYKhBLu8IomtDQ3tAsg8k-P8mbSJBC4INGQHX_%2Fitems%2F01NIM3TXJAXUR5CHLY35EIAFIDG5HW4OJT%3Ftempauth%3DeyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbXkubWljcm9zb2Z0cGVyc29uYWxjb250ZW50LmNvbUA5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJpc3MiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAiLCJuYmYiOiIxNzA5NDEzMjAwIiwiZXhwIjoiMTcwOTQzNDgwMCIsImVuZHBvaW50dXJsIjoiMTM5cDFNVkx5OTBMNW9KdEFuMlFmeUJIektUL1FLVzVoNE1MME10VUVZaz0iLCJlbmRwb2ludHVybExlbmd0aCI6IjE2NCIsImlzbG9vcGJhY2siOiJUcnVlIiwidmVyIjoiaGFzaGVkcHJvb2Z0b2tlbiIsInNpdGVpZCI6IlkyTmhObVJrTUdRdE5HSXdOeTAwTVRoaUxXSTJZelF0Tm1FeU5tVXpNelUwT1RReCIsImFwcF9kaXNwbGF5bmFtZSI6IkNvbnN1bWVyIEFwcDogMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0IiwiYXBwaWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwNDgxNzEwYTQiLCJ0aWQiOiI5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJ1cG4iOiJrYW5hbWF4QG91dGxvb2suZnIiLCJwdWlkIjoiMDAwMzAwMDA1M0I1NkQwQSIsImNhY2hla2V5IjoiMGguZnxtZW1iZXJzaGlwfDAwMDMwMDAwNTNiNTZkMGFAbGl2ZS5jb20iLCJzY3AiOiJhbGxzaXRlcy5mdWxsY29udHJvbCIsInNpZCI6IjE1MDUwNjU2Mzk5NTMyMTcwMTgzIiwidHQiOiIyIiwiaXBhZGRyIjoiNDEuMjAyLjIxOS43MyJ9.WtD3OPyyavkIuydwbWAoA9daVC8c_PvsOg4g_CiKURA%26version%3DPublished&cb=63844735173&encodeFailures=1&width=472&height=314",
                            nom="voitures",
                            prix=100,
                            nombre=1
                        },
                        new MainsOeuvre()
                        {
                            image="https://southcentralus1-mediap.svc.ms/transform/thumbnail?provider=spo&farmid=193369&inputFormat=png&cs=MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0fFNQTw&docid=https%3A%2F%2Fmy.microsoftpersonalcontent.com%2F_api%2Fv2.0%2Fdrives%2Fb!Dd2mzAdLi0G2xGom4zVJQeNrg9cYKhBLu8IomtDQ3tAsg8k-P8mbSJBC4INGQHX_%2Fitems%2F01NIM3TXNLWMAI7UIQEBB3DG3DSV5X7NJC%3Ftempauth%3DeyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbXkubWljcm9zb2Z0cGVyc29uYWxjb250ZW50LmNvbUA5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJpc3MiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAiLCJuYmYiOiIxNzA5NDEzMjAwIiwiZXhwIjoiMTcwOTQzNDgwMCIsImVuZHBvaW50dXJsIjoiQi9oV2NRNXozdUNxNytuTHplT2V2Mzg4TzBUMWtPMHl1bXRLbnB5T0ZPUT0iLCJlbmRwb2ludHVybExlbmd0aCI6IjE2NCIsImlzbG9vcGJhY2siOiJUcnVlIiwidmVyIjoiaGFzaGVkcHJvb2Z0b2tlbiIsInNpdGVpZCI6IlkyTmhObVJrTUdRdE5HSXdOeTAwTVRoaUxXSTJZelF0Tm1FeU5tVXpNelUwT1RReCIsImFwcF9kaXNwbGF5bmFtZSI6IkNvbnN1bWVyIEFwcDogMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0IiwiYXBwaWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwNDgxNzEwYTQiLCJ0aWQiOiI5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJ1cG4iOiJrYW5hbWF4QG91dGxvb2suZnIiLCJwdWlkIjoiMDAwMzAwMDA1M0I1NkQwQSIsImNhY2hla2V5IjoiMGguZnxtZW1iZXJzaGlwfDAwMDMwMDAwNTNiNTZkMGFAbGl2ZS5jb20iLCJzY3AiOiJhbGxzaXRlcy5mdWxsY29udHJvbCIsInNpZCI6IjE1MDUwNjU2Mzk5NTMyMTcwMTgzIiwidHQiOiIyIiwiaXBhZGRyIjoiNDEuMjAyLjIxOS43MyJ9.dqXhTg3nxJkc8SC7TJyZDhDJRGRi4JWWZPUMMtMWQyY%26version%3DPublished&cb=63844735194&encodeFailures=1&width=472&height=314",
                            nom="camions",
                            prix=100,
                            nombre=1
                        },
                        new MainsOeuvre()
                        {
                            image = "https://southcentralus1-mediap.svc.ms/transform/thumbnail?provider=spo&farmid=193369&inputFormat=png&cs=MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0fFNQTw&docid=https%3A%2F%2Fmy.microsoftpersonalcontent.com%2F_api%2Fv2.0%2Fdrives%2Fb!Dd2mzAdLi0G2xGom4zVJQeNrg9cYKhBLu8IomtDQ3tAsg8k-P8mbSJBC4INGQHX_%2Fitems%2F01NIM3TXL3QDQYTQGPWBCZS4LWJDVYU2FL%3Ftempauth%3DeyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbXkubWljcm9zb2Z0cGVyc29uYWxjb250ZW50LmNvbUA5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJpc3MiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAiLCJuYmYiOiIxNzA5NDEzMjAwIiwiZXhwIjoiMTcwOTQzNDgwMCIsImVuZHBvaW50dXJsIjoiOCsxQ0t2UCtvd1FGTm01Q2pXdjN1bkgvelRsU2JBMHp3T21EUTlobXR0cz0iLCJlbmRwb2ludHVybExlbmd0aCI6IjE2NCIsImlzbG9vcGJhY2siOiJUcnVlIiwidmVyIjoiaGFzaGVkcHJvb2Z0b2tlbiIsInNpdGVpZCI6IlkyTmhObVJrTUdRdE5HSXdOeTAwTVRoaUxXSTJZelF0Tm1FeU5tVXpNelUwT1RReCIsImFwcF9kaXNwbGF5bmFtZSI6IkNvbnN1bWVyIEFwcDogMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0IiwiYXBwaWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwNDgxNzEwYTQiLCJ0aWQiOiI5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJ1cG4iOiJrYW5hbWF4QG91dGxvb2suZnIiLCJwdWlkIjoiMDAwMzAwMDA1M0I1NkQwQSIsImNhY2hla2V5IjoiMGguZnxtZW1iZXJzaGlwfDAwMDMwMDAwNTNiNTZkMGFAbGl2ZS5jb20iLCJzY3AiOiJhbGxzaXRlcy5mdWxsY29udHJvbCIsInNpZCI6IjE1MDUwNjU2Mzk5NTMyMTcwMTgzIiwidHQiOiIyIiwiaXBhZGRyIjoiNDEuMjAyLjIxOS43MyJ9.xsIUehwnw4VlektJ3RNv4P3BcC9wK1RwxtUa6gtiYt8%26version%3DPublished&cb=63844790879&encodeFailures=1&width=472&height=314",
                            nom="motos",
                            prix=100,
                            nombre=1
                        },
                        new MainsOeuvre()
                        {
                            image = "https://southcentralus1-mediap.svc.ms/transform/thumbnail?provider=spo&farmid=193369&inputFormat=png&cs=MDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0fFNQTw&docid=https%3A%2F%2Fmy.microsoftpersonalcontent.com%2F_api%2Fv2.0%2Fdrives%2Fb!Dd2mzAdLi0G2xGom4zVJQeNrg9cYKhBLu8IomtDQ3tAsg8k-P8mbSJBC4INGQHX_%2Fitems%2F01NIM3TXLDMLCXLSYERBDZPSD7PTSRGYE7%3Ftempauth%3DeyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAvbXkubWljcm9zb2Z0cGVyc29uYWxjb250ZW50LmNvbUA5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJpc3MiOiIwMDAwMDAwMy0wMDAwLTBmZjEtY2UwMC0wMDAwMDAwMDAwMDAiLCJuYmYiOiIxNzA5NDEzMjAwIiwiZXhwIjoiMTcwOTQzNDgwMCIsImVuZHBvaW50dXJsIjoiUFVQSjJ0TDJuS0xobXdDNVgvNEpaNm54eTFORko4UUdiY2hVc2plaTh2WT0iLCJlbmRwb2ludHVybExlbmd0aCI6IjE2NCIsImlzbG9vcGJhY2siOiJUcnVlIiwidmVyIjoiaGFzaGVkcHJvb2Z0b2tlbiIsInNpdGVpZCI6IlkyTmhObVJrTUdRdE5HSXdOeTAwTVRoaUxXSTJZelF0Tm1FeU5tVXpNelUwT1RReCIsImFwcF9kaXNwbGF5bmFtZSI6IkNvbnN1bWVyIEFwcDogMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDQ4MTcxMGE0IiwiYXBwaWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwNDgxNzEwYTQiLCJ0aWQiOiI5MTg4MDQwZC02YzY3LTRjNWItYjExMi0zNmEzMDRiNjZkYWQiLCJ1cG4iOiJrYW5hbWF4QG91dGxvb2suZnIiLCJwdWlkIjoiMDAwMzAwMDA1M0I1NkQwQSIsImNhY2hla2V5IjoiMGguZnxtZW1iZXJzaGlwfDAwMDMwMDAwNTNiNTZkMGFAbGl2ZS5jb20iLCJzY3AiOiJhbGxzaXRlcy5mdWxsY29udHJvbCIsInNpZCI6IjE1MDUwNjU2Mzk5NTMyMTcwMTgzIiwidHQiOiIyIiwiaXBhZGRyIjoiNDEuMjAyLjIxOS43MyJ9.G2_kVMps5T7RUVs0oHdAkKbqeje3JHtn7yMS3dSy3ZY%26version%3DPublished&cb=63844720289&encodeFailures=1&width=538&height=429",
                            nom="tricycles",
                            prix=100,
                            nombre=1
                        },
                    });
                    context.SaveChanges();
                }
                //voitures
                if (!context.voitures.Any())
                {
                    context.voitures.AddRange(new List<Voiture>()
                    {
                        new Voiture()
                        {
                            image="https://i.pinimg.com/236x/03/94/96/0394962fc0da4b28f31b1135f13828b8.jpg",
                            nom="voitures",
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.sport
                        },
                        new Voiture()
                        {
                            image="https://i.pinimg.com/236x/a6/67/6b/a6676b861ea05af3f9dbb0172c5edc8f.jpg",
                            nom="voitures",
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.sport
                        },
                        new Voiture()
                        {
                            image = "https://i.pinimg.com/236x/89/cd/bb/89cdbba07c7c5cd0d4bd1d6a10d12879.jpg",
                            nom="voitures",
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.sport
                        },
                        new Voiture()
                        {
                            image = "https://i.pinimg.com/236x/a8/66/12/a866120d4ffa441703e32ee9933732f6.jpg",
                            nom="voitures",
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.sport
                        },
                        new Voiture()
                        {
                            image = "https://i.pinimg.com/236x/9d/f1/ba/9df1baab1ac78ac0a5eae504bdcba1a3.jpg",
                            nom="voitures",
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.SUV
                        },
                        new Voiture()
                        {
                            image = "https://i.pinimg.com/236x/be/39/d0/be39d0285d4a5b453d510ed90b8e77a1.jpg",
                            nom="voitures",
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.SUV
                        },
                        new Voiture()
                        {
                            image = "https://i.pinimg.com/564x/86/67/ab/8667ab77e1d705f6531a5322d75099a0.jpg",
                            nom="voitures",
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.SUV
                        },
                        new Voiture()
                        {
                            image = "https://i.pinimg.com/736x/b7/2d/da/b72dda1dadd43fabebe9b576eef38601.jpg",
                            nom="voitures",
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.SUV
                        },
                        new Voiture()
                        {
                            image = "https://i.pinimg.com/236x/50/d1/30/50d130254eae66ce30f2c132c6fd6abe.jpg",
                            nom="voitures",
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.SUV
                        },
                        new Voiture()
                        {
                            image = "https://i.pinimg.com/236x/04/0a/32/040a32ad76a00720b2daa648a15a49b2.jpg",
                            nom="voitures",
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.sport
                        },
                        new Voiture()
                        {
                            image = "https://i.pinimg.com/236x/f0/e1/81/f0e181ed29971b6659670e5e0fbdf6cc.jpg",
                            nom="voitures",
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.sport
                        },
                        new Voiture()
                        {
                            image = "https://i.pinimg.com/564x/b6/aa/79/b6aa7965ffc8e564d1ffaa620b599c65.jpg",
                            nom="voitures",
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.SUV
                        },
                    });
                    context.SaveChanges();
                }



                //freins
                if (!context.freins.Any())
                {
                    context.freins.AddRange(new List<freins>()
                    {
                        new freins()
                        {
                            image="https://i.pinimg.com/564x/f3/e2/fe/f3e2fe24079a1c5b13380419c67ba01f.jpg",
                            prix=100,
                            nombre=1,
                            marque = marque.Mercedes
                        },
                        new freins()
                        {
                            image="https://i.pinimg.com/564x/38/0e/ca/380ecaed97811e4937b30f75816c9d47.jpg",
                            prix=100,
                            nombre=1,
                            marque = marque.Isuzu
                        },
                        new freins()
                        {
                            image = "https://i.pinimg.com/564x/3d/e3/10/3de3106ff64432831c81ffcc6ec7a0b4.jpg",
                            prix=100,
                            nombre=1,
                            marque = marque.Ford
                        },
                    });
                    context.SaveChanges();
                }
                //batteries
                if (!context.batteries.Any())
                {
                    context.batteries.AddRange(new List<batterie>()
                    {
                        new batterie()
                        {
                            image="https://i.pinimg.com/564x/32/c3/c3/32c3c36a5b42e0beeccf4914dc8fbbae.jpg",
                            prix=100,
                            nombre=1,
                            marque = marque.Isuzu
                        },
                        new batterie()
                        {
                            image="https://i.pinimg.com/564x/0e/19/a2/0e19a296aabf98f0054b28ff7a66fa0f.jpg",
                            prix=100,
                            nombre=1,
                            marque = marque.Ford
                        },
                        new batterie()
                        {
                            image = "https://i.pinimg.com/736x/4c/8a/01/4c8a011e0e98c1f591e1b0af6c2ddf53.jpg",
                            prix=100,
                            nombre=1,
                            marque = marque.Mercedes
                        },
                    });
                    context.SaveChanges();
                }
                //moteurs
                if (!context.moteurs.Any())
                {
                    context.moteurs.AddRange(new List<moteur>()
                    {
                        new moteur()
                        {
                            image="https://i.pinimg.com/236x/94/13/cc/9413cc1e3d5a248eff7bdbbefca95feb.jpg",
                            prix=100,
                            nombre=1,
                            marque = marque.Isuzu
                        },
                        new moteur()
                        {
                            image="https://i.pinimg.com/564x/b7/f8/29/b7f829bc9043e4a034db97fcfe2220cf.jpg",
                            prix=100,
                            nombre=1,
                            marque = marque.Ford
                        },
                        new moteur()
                        {
                            image = "https://i.pinimg.com/236x/89/c9/2a/89c92a4a346cae12ec63bc2f0fa6fe68.jpg",
                            prix=100,
                            nombre=1,
                            marque = marque.Mercedes
                        },
                    });
                    context.SaveChanges();
                }
                //suspensions
                if (!context.suspensions.Any())
                {
                    context.suspensions.AddRange(new List<Suspension>()
                    {
                        new Suspension()
                        {
                            image="https://i.pinimg.com/564x/1e/80/7c/1e807c295ad5860a2f55b70ab8bd4c03.jpg",
                            prix=100,
                            nombre=1,
                            marque = marque.Isuzu
                        },
                        new Suspension()
                        {
                            image="https://i.pinimg.com/736x/bd/9e/67/bd9e67c908338fd0319a6d7390dd9b79.jpg",
                            prix=100,
                            nombre=1,
                            marque = marque.Ford
                        },
                        new Suspension()
                        {
                            image = "https://i.pinimg.com/564x/7b/b9/da/7bb9da6c9a80f722ae644a71ce5bdade.jpg",
                            prix=100,
                            nombre=1,
                            marque = marque.Mercedes
                        },
                    });
                    context.SaveChanges();
                }
                //suspensions
                if (!context.turboCompresseur.Any())
                {
                    context.turboCompresseur.AddRange(new List<TurboCompresseur>()
                    {
                        new TurboCompresseur()
                        {
                            image="https://i.pinimg.com/564x/a0/45/1f/a0451f39d49002737f2fe0e282782701.jpg",
                            prix=100,
                            nombre=1,
                            marque = marque.Isuzu
                        },
                        new TurboCompresseur()
                        {
                            image="https://i.pinimg.com/236x/a4/a9/9a/a4a99a88dfbf8b836375605d526592cb.jpg",
                            prix=100,
                            nombre=1,
                            marque = marque.Ford
                        },
                        new TurboCompresseur()
                        {
                            image = "https://i.pinimg.com/564x/2c/a9/6d/2ca96da4f55698c56bcb0b66c089ec63.jpg",
                            prix=100,
                            nombre=1,
                            marque = marque.Mercedes
                        },
                    });
                    context.SaveChanges();
                }

                //voitures
                if (!context.reparations.Any())
                {
                    context.reparations.AddRange(new List<Reparation>()
                    {
                        new Reparation()
                        {
                            image="https://i.pinimg.com/564x/86/67/ab/8667ab77e1d705f6531a5322d75099a0.jpg",
                            nom="Reparations",
                            description="Reparations",
                            statut=true,
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.sport
                        },
                        new Reparation()
                        {
                            image="https://i.pinimg.com/236x/03/94/96/0394962fc0da4b28f31b1135f13828b8.jpg",
                            nom="camions",
                            description="Reparations",
                            statut=false,
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.sport
                        },
                        new Reparation()
                        {
                            image = "https://i.pinimg.com/736x/b7/2d/da/b72dda1dadd43fabebe9b576eef38601.jpg",
                            nom="motos",
                            description="Reparations",
                            statut=true,
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.sport
                        },
                        new Reparation()
                        {
                            image = "https://i.pinimg.com/564x/86/67/ab/8667ab77e1d705f6531a5322d75099a0.jpg",
                            nom="tricycles",
                            description="Reparations",
                            statut=false,
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.sport
                        },
                        new Reparation()
                        {
                            image = "https://i.pinimg.com/564x/4e/3c/d7/4e3cd7703945d70ab16cbad1ef18feb7.jpg",
                            nom="tricycles",
                            description="Reparations",
                            statut=true,
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.SUV
                        },
                        new Reparation()
                        {
                            image = "https://i.pinimg.com/236x/be/39/d0/be39d0285d4a5b453d510ed90b8e77a1.jpg",
                            nom="tricycles",
                            description="Reparations",
                            statut=false,
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.SUV
                        },
                        new Reparation()
                        {
                            image = "https://i.pinimg.com/236x/9d/f1/ba/9df1baab1ac78ac0a5eae504bdcba1a3.jpg",
                            nom="tricycles",
                            description="Reparations",
                            statut=true,
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.SUV
                        },
                        new Reparation()
                        {
                            image = "https://i.pinimg.com/564x/b6/aa/79/b6aa7965ffc8e564d1ffaa620b599c65.jpg",
                            nom="tricycles",
                            description="Reparations",
                            statut=false,
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.SUV
                        },
                        new Reparation()
                        {
                            image = "https://i.pinimg.com/236x/50/d1/30/50d130254eae66ce30f2c132c6fd6abe.jpg",
                            nom="tricycles",
                            description="Reparations",
                            statut=true,
                            prix=100,
                            nombre=0,
                            categorie= categorieVoiture.SUV
                        },
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
