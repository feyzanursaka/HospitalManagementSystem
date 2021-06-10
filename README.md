# Projenin Konusu 

<h5>Hastane Randevu Sistemini Yönetir.</h5>
<h5>Doktor, Hasta ve Randevunun CRUD işlemlerini gerçekleştirir.</h5> 
<h5>Hasta için istenilen doktoru ve günü seçerek randevu oluşturulabilir</h5>

# DataBase Images

<img src="https://github.com/feyzanursaka/HospitalManagement-frontend/blob/master/ss/11.PNG">
<img src="https://github.com/feyzanursaka/HospitalManagement-frontend/blob/master/ss/12.PNG">
<img src="https://github.com/feyzanursaka/HospitalManagement-frontend/blob/master/ss/13.PNG">

# Eksikler
Doctor silme işlemi Patiente bağlı olduğu için gerçekleştirilmemiştir

# Kullanılan Teknolojiler   
<ul style="list-style-type:disc">
 <li>.NET</li>
 <li>ASP.NET</li>
    <ul>
      <li>Microsoft'un web geliştirme ortamının ve bunları içeren kütüphanelerin toplandığı yapıdır.</li> 
      <li>.NET projelerindeki web projelerine verilen isimdir.</li>
      <li>Apı Restful Mimariyi destekler.</li>
      <li>Restful Mimari, geliştirdiğimiz .NET'i tanımayan bir Java uygulamasının, IOS uygulamasının vb. bizim sistemimizle iletişim kurmasını sağlayan bir ortamdır.</li>
      <li>Proje, ASP.NET.Core altyapısıyla geliştirilmiştir.</li>
    </ul> 
 <li>EntityFramework Core</li>
 <li>Autofac</li>
    <ul>
      <li>Instance üretimini sağlayan yapıdır.</li> 
    </ul> 
 <li>MsSql</li> 
 <li><a href="https://github.com/feyzanursaka/HospitalManagement-frontend">Angular for Frontend</a></li> 
</ul>

# Kullanılan Teknikler  
<ul style="list-style-type:disc">
 <li>Layered Architecture Design Pattern</li>
 <li>AOP</li>
    <ul>
      <li>Bir metodun önünde, sonunda veya hata verdiğinde çalışan kod parçacığı AOP mimarisi ile yazılır.</li> 
      <li>Autofac AOP imkanı sunuyor.</li>
      <li>Bu sayede .NET'in IoC Container'ına Autofac enjekte edilir.</li>
    </ul> 
 <li>IOC (Inversion of control)</li> 
    <ul>
      <li>Değişimin Kontrolü</li> 
      <li>Hiçbir katman diğerini newlemez, bu işlemi IoC yapar.</li>
      <li>Mesela CarController'ın ICarService'e ihtiyacı varsa, ASP.NET, Web API IoC Container'a bakar karşılık geleni kullanır.</li>
      <li>Tüm bellekte bir tane DoctorManager oluşturulur. Birden fazla client gelsede hepsine aynı instance referansını verir.</li>
    </ul> 
</ul>
# Katmanlar

<p>Proje, farklı katmanlar oluşturularak Plug and Play (Tak ve Çalıştır) Sistemler şeklinde yazıldı.
<h3>1.Business</h3>
<h3>2.Core</h3>
<h3>3.Data Access</h3>
<h3>4.Entities</h3>
<h3>5.API</h3>

