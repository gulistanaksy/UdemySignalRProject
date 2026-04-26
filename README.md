# UdemySignalRProject

`UdemySignalRProject`, restoran yonetimi senaryosu uzerinden gelistirilmis cok katmanli bir `ASP.NET Core` uygulamasidir. Proje; `Web API`, `SignalR`, `Entity Framework Core`, `DTO`, `AutoMapper` ve servis/repository yapisini ayni cozum icinde bir araya getirir.

Uygulama yapisi backend odaklidir. MVC tabanli bir WebUI katmani bulunsa da projenin ana amaci; veri modelleri, servis katmani, API endpointleri ve gercek zamanli veri akisi uzerinden backend tarafini kurgulamak ve uygulamaktir.

## Proje Kapsami

Proje, restoran yonetimi senaryosu icin su alanlari kapsar:

- Kategori yonetimi
- Urun yonetimi
- Indirim alanlari
- Rezervasyon islemleri
- Hakkimizda ve iletisim icerikleri
- Sosyal medya ve slider yonetimi
- Testimonial alanlari
- Siparis ve siparis detayi yapisi
- Masa ve sepet mantigi
- Kasa ve ozet istatistik verileri

Bu kapsam sayesinde yalnizca temel CRUD islemleri degil, birbirine bagli moduller ve ozet veri ihtiyaclari da ele alinmistir.

## Kullanilan Teknolojiler

- `ASP.NET Core 6`
- `ASP.NET Core Web API`
- `ASP.NET Core MVC`
- `SignalR`
- `Entity Framework Core`
- `SQL Server`
- `AutoMapper`
- `Swagger / OpenAPI`
- `Newtonsoft.Json`

## Cozum Yapisi

Proje asagidaki katmanlardan olusur:

- `SignalR.EntityLayer`
  Entity siniflari ve veritabani varliklari

- `SignalR.DtoLayer`
  API istek/yanit modellerinde kullanilan DTO siniflari

- `SignalR.DataAccessLayer`
  `DbContext`, generic repository yapisi, Entity Framework tabanli veri erisim siniflari ve migration dosyalari

- `SignalR.BusinessLayer`
  Servis arayuzleri ve manager siniflari

- `SignalRApi`
  Web API endpointleri, dependency injection kayitlari, AutoMapper konfigurasyonu ve `SignalR Hub`

- `SignalRWebUI`
  MVC tabanli istemci katmani

## One Cikan Teknik Noktalar

- Katmanli mimari yaklasimi kullanilmistir
- Entity ve DTO modelleri ayri tutulmustur
- Generic repository tabanli veri erisim yapisi kurulmustur
- Service/manager siniflari ile business katmani ayrilmistir
- `AutoMapper` ile nesne donusumleri uygulanmistir
- `SignalR` ile anlik veri yayini yapilmistir
- WebUI katmani API tuketen istemci gibi kurgulanmistir

## SignalR Kullanimi

Projede `SignalR`, dashboard ve istatistik ekranlari icin gercek zamanli veri aktariminda kullanilmistir. Hub uzerinden yayinlanan veriler arasinda sunlar bulunur:

- Toplam kategori sayisi
- Toplam urun sayisi
- Aktif ve pasif kategori sayilari
- Belirli kategorilere gore urun adetleri
- Ortalama urun fiyati
- En pahali ve en dusuk fiyatli urun bilgileri
- Toplam siparis sayisi
- Aktif siparis sayisi
- Son siparis tutari
- Toplam kasa tutari
- Masa sayisi

Bu yapi, klasik CRUD akislarina ek olarak gercek zamanli veri guncellemesi senaryosunu da projeye dahil eder.

## API ve Uygulama Katmanlari

API tarafinda farkli moduller icin controller yapilari bulunur. Bunlar arasinda:

- `Category`
- `Product`
- `Booking`
- `Discount`
- `About`
- `Contact`
- `SocialMedia`
- `Testimonial`
- `Slider`
- `Basket`
- `Order`
- `MoneyCase`
- `MenuTable`

Controller katmani servislerle, servisler de veri erisim katmaniyla baglanir. Bu yapi sayesinde sorumluluklar katmanlara ayrilarak daha duzenli bir cozum hedeflenmistir.

## Kurulum

Projeyi lokal ortamda calistirmak icin:

1. Repo'yu klonlayin.
2. `SignalR.DataAccessLayer/Concrete/SignalRContext.cs` icindeki connection string bilgisini kendi SQL Server ortaminiza gore guncelleyin.
3. Gerekliyse migrationlari veritabanina uygulayin.
4. Once `SignalRApi`, ardindan `SignalRWebUI` projesini calistirin.

Varsayilan gelistirme portlari:

- `SignalRApi`: `https://localhost:7296`
- `SignalRWebUI`: `https://localhost:55821`

## Notlar

- Veritabani baglantisi mevcut yapida dogrudan `DbContext` icinde tanimlanmistir.
- Proje `net6.0` hedefler.
- Migration dosyalari `SignalR.DataAccessLayer/Migrations` altinda yer alir.
- Swagger, API projesinde development ortaminda aciktir.

## Gelistirme Olanaklari

Proje asagidaki alanlarda daha ileri seviyeye tasinabilir:

- Connection string ve benzeri ayarlari `appsettings.json` uzerine tasimak
- Validation yapisini guclendirmek
- Hata yonetimini standartlastirmak
- Yetkilendirme ve kimlik dogrulama eklemek
- Unit test ve integration test altyapisi olusturmak
- Tekrar eden kodlari refactor etmek
- API ve WebUI arasindaki endpoint uyumunu genisletmek

## Ozet

Bu proje, restoran yonetimi senaryosu uzerinden backend mimarisi kurma, veri erisimi tasarlama, API gelistirme ve `SignalR` ile gercek zamanli veri akisi saglama konularina odaklanan bir uygulamadir. Katmanli yapi, moduler organizasyon ve gercek senaryoya yakin domain kapsamiyla, backend gelistirme pratigi icin anlamli bir ornek sunar.
