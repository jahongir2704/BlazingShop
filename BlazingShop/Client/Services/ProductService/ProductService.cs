using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get ; set; } = new List<Product>();

        public void LoadProducts()
        {
          
            Products = new List<Product>
    {
               new Product {
                   Id = 1,
                   CategoryId = 1,
                   Title = "Dota 2",
                   Description = "Dota 2 — компьютерная многопользовательская командная игра в жанре multiplayer online battle arena, разработанная корпорацией Valve. Игра является продолжением DotA — пользовательской карты-модификации для игры Warcraft III: Reign of Chaos и дополнения к ней Warcraft III: The Frozen Throne. Игра изображает сражение на карте особого вида; в каждом матче участвуют две команды по пять игроков, управляющих «героями» — персонажами с различными наборами способностей. Для победы в матче команда должна уничтожить особый объект-«крепость», принадлежащий вражеской стороне, и защитить от уничтожения собственную «крепость». Dota 2 работает по модели free-to-play с элементами микроплатежей.",
                   Image = "https://upload.wikimedia.org/wikipedia/ru/8/8e/%D0%9E%D0%B1%D0%BB%D0%BE%D0%B6%D0%BA%D0%B0_Dota_2.jpg",
                   Price = 4.99m,
                   OriginalPrice = 9.99m
               },

               new Product {
                   Id = 2,
                   CategoryId = 2,
                   Title = "Total War: Warhammer III",
                   Description = "Total War: Warhammer III — грядущая компьютерная игра в жанрах пошаговой стратегии и стратегии в реальном времени, разработанная компанией Creative Assembly и планируемая к изданию Sega. Была анонсирована 3 февраля 2021 года, релиз изначально был запланирован на начало 2022 года, а позже перенесён на 17 февраля.[1]. Это пятнадцатая игра в серии Total War и третья в трилогии на основе сеттинга Warhammer Fantasy[2][3]. Является частью Xbox Game Pass.",
                   Image = "https://upload.wikimedia.org/wikipedia/ru/2/27/Total_War_Warhammer_3_cover_art.jpg",
                   Price = 14.99m,
                   OriginalPrice = 29.99m
               },

               new Product {
                   Id = 3,
                   CategoryId = 3,
                   Title = "Far Cry 6",
                   Description = "Far Cry 6 — компьютерная игра в жанре шутера от первого лица и action-adventure, разработанная студией Ubisoft Toronto и изданная компанией Ubisoft. Является шестой основной игрой из одноимённой серии[2]. Действие происходит в вымышленной тропической стране Яра, и повествует о противостоянии главного героя (или героини) местного сопротивления по имени Дани Рохас и жестокого диктатора Антона Кастильо (Джанкарло Эспозито)[3]. Создатели были вдохновлены действиями партизан Кубы[4]. На официальном сайте Far Cry 6 назван политической игрой, сюжет которой рассказывает о современной революции[5]. Выход игры состоялся 7 октября 2021 года для Windows, PlayStation 4, PlayStation 5, Xbox One и Xbox Series X/S.",
                   Image = "https://upload.wikimedia.org/wikipedia/ru/d/d6/Far_cry_6.jpeg",
                   Price = 24.99m,
                   OriginalPrice = 49.99m
               },

               new Product {
                   Id = 4,
                   CategoryId = 4,
                   Title = "Веном 2",
                   Description = "«Ве́ном 2» (англ. Venom: Let There Be Carnage) — американский супергеройский фильм, основанный на персонаже Marvel Comics Веноме, созданный Columbia Pictures в сотрудничестве с Marvel и Tencent Pictures и распространяемый Sony Pictures Releasing. Фильм является продолжением ленты 2018 года и второй картиной в рамках вселенной Человека-паука от Sony. Режиссёром выступил Энди Серкис, сценарий написала Келли Марселruen на основе сюжета, созданного ею и Томом Харди, который исполнил роль Эдди Брока / Венома. Также в фильме сыграли Мишель Уильямс, Наоми Харрис, Рид Скоттruen, Стивен Грэм и Вуди Харрельсон. По сюжету Эдди Брок пытается вернуться в журналистику, взяв интервью у серийного убийцы Клетуса Кэседи, который становится носителем симбиотаruen по имени Карнаж.",
                   Image = "https://upload.wikimedia.org/wikipedia/ru/8/8e/Venom_-_Let_There_Be_Carnage.jpg",
                   Price = 8.99m,
                   OriginalPrice = 17.99m
               },

               new Product {
                   Id = 5,
                   CategoryId = 5,
                   Title = "Морбиус",
                   Description = "Морбиус - это новый американский фильм о супергероях, основанный наперсонаже Marvel Comics Морбиус, Живой вампир , снятый Columbia Pictures совместно с Marvel . Это будет третий фильм во вселенной Человека-паука Sony, режиссер Даниэль Эспиноза, сценарий Мэтта Сазамы и Берка Шарплесса с Джаредом Лето в роли Майкла Морбиуса вглавных роляхвместе с Мэттом Смитом , Адрией Арджоной , Джаредом Харрисом , Аль Мадригал. , и Тайриз Гибсон. Фильм рассказывает о том, как главный герой становится вампиром после попытки вылечить себя от редкой болезни крови.",
                   Image = "https://upload.wikimedia.org/wikipedia/ru/d/d4/Morbius_%28film%29_official_poster.jpg",
                   Price = 7.99m,
                   OriginalPrice = 15.99m
               },

               new Product {
                   Id = 6,
                   CategoryId = 6,
                   Title = "Вечные",
                   Description = "«Ве́чные» (англ. Eternals) — американский художественный фильм, основанный на комиксах издательства Marvel, созданный студией Marvel Studios и распространяемый компанией Walt Disney Studios Motion Pictures. 26-й по счёту фильм кинематографической вселенной Marvel. Режиссёром ленты является Хлоя Чжао, которая также написала сценарий вместе с Патриком Бёрли и Райаном и Казом Фирпоruen. Главные роли исполнили Джемма Чан, Ричард Мэдден, Кумэйл Нанджиани, Лия Макхьюruen, Брайан Тайри Генри, Лорен Ридлофф, Барри Кеоган, Дон Лиruen, Хариш Пательruen, Кит Харингтон, Сальма Хайек и Анджелина Джоли. По сюжету фильма Вечные, бессмертная инопланетная раса, спустя тысячи лет выходят из тени, чтобы защитить Землю от своих злых собратьев, Девиантов.",
                   Image = "https://upload.wikimedia.org/wikipedia/ru/0/04/%D0%92%D0%B5%D1%87%D0%BD%D1%8B%D0%B5_%D0%BE%D1%84%D0%B8%D1%86%D0%B8%D0%B0%D0%BB%D1%8C%D0%BD%D1%8B%D0%B9_%D0%BF%D0%BE%D1%81%D1%82%D0%B5%D1%80.jpg",
                   Price = 6.99m,
                   OriginalPrice = 13.99m
               },

            new Product {
                   Id = 7,
                   CategoryId = 7,
                   Title = "PlayStation 5",
                   Description = "PlayStation 5 (яп. プレイステーション5 Пурэйсутэ:сён Файбу, официальное сокр. PS5) — игровая приставка, разработанная и выпускаемая японской компанией Sony Interactive Entertainment.PlayStation 5 является представительницей семейства игровых консолей PlayStation и преемницей PlayStation 4.Старт продаж состоялся 12 ноября 2020 года в США, Канаде, Мексике, Южной Корее, Японии, Австралии и Новой Зеландии, а 19 ноября 2020 года и в остальных регионах[1].=Разработка была официально подтверждена в октябре 2018 года[10], а первые подробности появились в апреле 2019 года[11].",
                   Image = "https://mydevice.by/image/cache/data/Content/Consoles/PS5/Digital_Edition/playstation-5-digital-edition-5910-1000x1000.jpg",
                   Price = 990m,
                   OriginalPrice = 1250m
               },

               new Product {
                   Id = 8,
                   CategoryId = 8,
                   Title = "Acer Predator Helios 300 PH315-54-760S Gaming Laptop",
                   Description = "Acer Predator Helios 300 PH315-54-760S Gaming Laptop | Intel i7-11800H | NVIDIA GeForce RTX 3060 Laptop GPU | 15.6 Full HD 144Hz 3ms IPS Display | 16GB DDR4 | 512GB SSD | Killer WiFi 6 | RGB Keyboard",
                   Image = "https://m.media-amazon.com/images/I/71Nly9vPapL._AC_SL1500_.jpg",
                   Price = 1299m,
                   OriginalPrice = 1499m
               },

               new Product {
                   Id = 9,
                   CategoryId = 9,
                   Title = "PREDATOR THRONOS",
                   Description = "Все аппаратное обеспечение Predator в едином централизованном устройстве — это настоящий гигант игровых кресел, обеспечивающий полное погружение в игровую атмосферу. Наслаждайтесь безупречной игрой благодаря трем дисплеям Predator Z271U, а также исключительной производительности процессоров Intel® Core™ 8-го поколения и видеокарте GeForce RTX™ настольных ПК Orion.",
                   Image = "https://cdn1.technopark.ru/technopark/photos_resized/product/1000_1000/181569/1_181569.jpg",
                   Price = 18000m,
                   OriginalPrice = 22000m
               },
            };
        }
    }
}
