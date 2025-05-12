using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerClub
{
    public class TariffService
    {
        public List<(string TariffName, int SessionCount)> GetPopularTariffs()
        {
            using (var context = PC_ClubEntities5.GetContext())
            {
                context.Configuration.LazyLoadingEnabled = false;  // <-- Отключаем

                var result = context.Receipt
                    .Join(context.Session,
                        check => check.SessionID,
                        session => session.SessionID,
                        (check, session) => new { session.Rate })
                    .GroupBy(x => x.Rate)
                    .Select(group => new
                    {
                        RateName = group.Key.RateName,
                        Count = group.Count()
                    })
                    .OrderByDescending(x => x.Count)
                    .Take(10)
                    .ToList()
                    .Select(x => (x.RateName, x.Count))
                    .ToList();

                return result;
            }
        }
    }
}
