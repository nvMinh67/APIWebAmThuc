using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using webanthuc.Entity;
using webanthuc.Model;

namespace webanthuc.Repositories
{
    public class DishRepository : IDishRepository
    {
        private readonly MyDbContext _context;

        public DishRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<int> add([FromForm] DishModel dish)
        {
            var newdish = new Dish1()
            {
                Name = dish.name,
                price = dish.price,
            };
            _context.Dish1s.Add(newdish);
            await _context.SaveChangesAsync();
            if (newdish.Id == null)
            {
                return newdish.Id;

            }
            var getCurrenDirectory = Directory.GetCurrentDirectory();

            foreach (var item in dish.ImageUploads)
            {
                var path = Path.Combine(getCurrenDirectory, "Upload\\files", item.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await item.CopyToAsync(stream);
                }
                var image = new Image_Dish1()
                {
                    IdDish1 = newdish.Id,
                    Name = "Upload/files/" + item.FileName,
                };
                _context.Image_Dish1s.Add(image);
            }
            var menu = new Menu1()
            {
                id_dish1 = newdish.Id,
                id_restaurant1 = Convert.ToInt32(dish.maso),
            };
            _context.menus1.Add(menu);
            await _context.SaveChangesAsync();
            return newdish.Id;

        }

        public Task delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<DishInformation> get(int id)
        {
            #region
            // Get list Id of DishInformation 
            //var listDishIds = (from d in _context.Dish1s.AsNoTracking()
            //                   where
            //                      select d.Id).ToList();

            //var dddd =
            //    from img in _context.Image_Dish1s.AsNoTracking()

            //    where img.IdDish1 == id
            //    select new
            //    {
            //        DishID = img.Id,
            //        Image = img.Name
            //    };

            //var listImages =
            //    from img in _context.Image_Dish1s.AsNoTracking()

            //    where img.IdDish1 == id

            //    group img.Name by img.IdDish1 into g
            //    select new
            //    {
            //        IdDish = g.Key,
            //        Images = g.ToList()
            //    };

            //var test = _context.Image_Dish1s.AsNoTracking()
            //                                .Select(x => new { IdDish1 = x.IdDish1, Name = x.Name })
            //                                .Where(x => x.IdDish1 == id)
            //                                .GroupBy(x => x.IdDish1)
            //                                .Select(x => new
            //                                {
            //                                    Id = x.Key,
            //                                    Images = x.ToList()
            //                                });

            // IQueryable => sẽ được chạy dưới DB => Sẽ select dưới Sql server
            // IEnumerable vs ICollection vs IList  => sẽ được kéo lên RAM và sẽ chạy trên RAM

            //
            //var ddddd111 =
            //    (from img in _context.Image_Dish1s.AsNoTracking()

            //     where img.IdDish1 == id

            //     select new
            //     {
            //         IdDish1 = img.IdDish1,
            //         Name = img.Name
            //     }
            //    ).GroupBy(x => x.IdDish1)
            //                                .Select(x => new
            //                                {
            //                                    Id = x.Key,
            //                                    Images = x.ToList()
            //                                });

            #endregion

            var disListCach2 = await (from d in _context.Dish1s.AsNoTracking()
                                      where d.Id == id
                                      join m in _context.menus1 on d.Id equals m.id_dish1
                                      select new DishInformation()
                                      {
                                          maso = d.Id,
                                          Name = d.Name,
                                          price = d.price,
                                          Image = (from img in _context.Image_Dish1s.AsNoTracking()
                                                   where img.IdDish1 == d.Id
                                                   select img.Name).ToList(),
                                          restaurantId = Convert.ToInt32(m.id_restaurant1),

                                      }).FirstOrDefaultAsync();

            // Phân biệt giữa interface với abstract class
            // Web APi có nhiêu loại Web API:
            // + REST API => Thường sử dụng
            // + SOAP API => Công nghệ cũ,nó sẽ chạy chậm hơn vì nó thao tác file xml.
            // + GRAP
            // + ......
            // == với Equals 
            // Hướng đối tượng là gì => 4 tính chất => đóng gói, kế thừa, trừu tượng, đa hình
            // C# cơ bản => Access modifier có những cái nào (public, private, protect, internal) => phạm vi truy cập của nó
            // Kiểu dữ liệu: var, dynamic, object,...
            // Viết Web thì sẽ sử dụng công nghệ nào => ASP.NET
            // Viết Web sử dụng công nghệ ASP.NET có những framework nào để kết nối database : ADO.NET, Dapper, Entity
            // Biết Linq ko?
            // Trong xác thực thì sẽ có framework nào: Identity
            // Liên quan đến Excell, PDF: EPPlus,...
            // Sự khác biệt của ASP.NET với ASP.NET core
            // Trong ASP.NET core, Dependency Injection (DI)
            // SQL: câu hỏi về truy vấn (select, from, where, uninon = concat, groupby, sum, delete, insert,...), store procedure, function, CTE, VIEW, Index,.....
            // WPF => để viết App Destop
            // Lương tầm 9-12tr, + tiền Income (tiền dự án) đối 3tr => Dev 1 = 15 ~ 16tr, Dev 2 : 12~20, ...... => cách làm trong một công ty như thế nào, môi trường làm việc,.....

            // Muốn lương cao hơn thì data, cloud, AI => Data với AI ít việc nhưng lương cao và tuyển quái vật, cloud (AWS -> Amazone (Cert đắt), Azure -> Mircosoft (Cert rẻ hơn), Google Cloud -> Google, ....) phổ thông hơn dễ học hơn nhiều tài liệu hơn tuyển normal


            // Nếu vào được FPT => Công ty sẽ hỗ trợ thì các chứng của AWS và Azure (nếu thi pass chứng chỉ sẽ trả tiền thi)
            //=> Mở miễn phí account Udemy để học các skill => free
            //=> Miễn các khóa học trên Udacity (chứng chỉ quốc tế) => mỗi udacity từ ngàn đô trở lên nhưng công ty lo
            //=> Phân bậc, vd về dev thì sẽ có 6 bậc, Dev 6  (Trùm về một công nghệ) lẽ được cưng như trứng, cty đéo đuổi,....
            // + SA: Solution Architect => Khó làm đéo được ổng sẽ hỗ trợ
            // + PM: Project Manager => Quản lý dự án => Chia Task của project
            // + Sub-PM: sẽ hỗ trợ PM chính
            // + Leader (Dev có nhiều kinh nghiệm có thể từ Dev 2 => Xem xét task và lại cho người phù hợp): Quản lý team nhỏ 
            // + BA: Phân tích nghiệm vụ lấy yêu cầu từ khác hàng 

            //var dislist = await (from d1 in _context.Dish1s
            //                     join img in listImages on d1.Id equals img.IdDish
            //                     select new DishInformation()
            //                     {
            //                         maso = d1.Id,
            //                         Name = d1.Name,
            //                         price = d1.price,
            //                         Image = img.Images,

            //                     }).FirstOrDefaultAsync();

            //var dislist = await (from d1 in _context.Dish1s
            //                     join img in listImages on d1.Id equals img.IdDish
            //                     select new DishInformation()
            //                     {
            //                         maso = d1.Id,
            //                         Name = d1.Name,
            //                         price = d1.price,
            //                         Image = img.Images,

            //                     }).FirstOrDefaultAsync();
            return disListCach2;

        }

        public async Task<List<DishInformation>> getAll()
        {
            var disList = await (from d in _context.Dish1s.AsNoTracking()
                                     join m in _context.menus1 on d.Id equals m.id_dish1
                                      select new DishInformation()
                                      {
                                          maso = d.Id,
                                          Name = d.Name,
                                          price = d.price,
                                          Image = (from img in _context.Image_Dish1s.AsNoTracking()
                                                   where img.IdDish1 == d.Id
                                                   select img.Name).ToList(),
                                          restaurantId = Convert.ToInt32(m.id_restaurant1),

                                      }).ToListAsync();
            return disList;
        }
        public async Task<int> update(int id, [FromForm] DishModel dish)
        {
            var dishinList = await _context.Dish1s.SingleOrDefaultAsync(di => di.Id == id);
            if (dishinList == null)
            {
                return 400;
            }
            dishinList.price = dish.price;
            dishinList.Name = dish.name;
            var getCurrenDirectory = Directory.GetCurrentDirectory();
            foreach (var item in dish.ImageUploads)
            {
                var path = Path.Combine(getCurrenDirectory, "Upload\\files", item.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await item.CopyToAsync(stream);
                }
                var image = new Image_Dish1()
                {
                    IdDish1 = id,
                    Name = "Upload/files/" + item.FileName,
                };
                _context.Image_Dish1s.Add(image);
            }
        
            await _context.SaveChangesAsync();

            return id;

        }
        async Task<int> IDishRepository.delete(int id)
        {
            var menu = await _context.menus1.SingleOrDefaultAsync(menu => menu.id_dish1 == id);
            if (menu == null)
            {
                return 404;
            }
            _context.menus1.Remove(menu);
            await _context.SaveChangesAsync();
            var image = await _context.Image_Dish1s.FindAsync(id);
            if (image == null)
            {
                return 404;
            }
            var dish = await _context.Dish1s.FirstOrDefaultAsync();
            if (dish == null)
            {
                return 404;
            }
            _context.Dish1s.Remove(dish);
            await _context.SaveChangesAsync();
            return id;
        }

        // public async Task<int> delete (int id)
        //{
        //   var dish =  await _context.Dish1s.SingleOrDefaultAsync(di => di.Id == id);
        //    if (dish == null) { return 400; }
        //    return id;
        //}
    }

       

      
    }

