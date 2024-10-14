
#  MultiShop- MikroServis E-Ticaret Sitesi

MultiShop E-Ticaret projesi, mikroservis mimarisi kullanılarak geliştirilen çok katmanlı bir e-ticaret platformudur. Proje, ASP.Net Core 8.0 ve çeşitli teknolojilerle donatılmış olup, farklı mikroservisler üzerinden birçok özelliği sunar. MultiShop’un en dikkat çeken yönü, her bir mikroservisin belirli bir işlevi yerine getirmek için tasarlanmış olmasıdır. Böylelikle, sistem modüler bir yapıda geliştirilmiş ve yönetimi kolaylaştırılmıştır.


##  Projenin Kapsamı

🚀 ASP.Net Core 8.0 ile geliştirdiğim projede, Catalog, Basket, Order, Payment, Comment, Cargo, Discount ve Identity Server gibi farklı mikroservisler bulunmaktadır.


🚀 Projenin güvenlik kısmı, Identity ve JWT (JSON Web Token) ile sağlanmıştır.


🚀 Mikro hizmet mimarilerinin karmaşıklığını azaltmak ve API yönetimini büyük ölçüde kolaylaştırmak için Ocelot kullanılmıştır. API'leri test etmek amacıyla Postman ve Swagger araçları kullanılmıştır.


🚀 Localization kullanılararak, kullanıcılara diledikleri dilde içerik sunma imkanı sağlanmış ve uygulamanın çok dilli yapısı kullanıcı tercihine göre sunulmuştur.


🚀 Uygulamanın yalnızca yerel ortamda çalışmakla sınırlı kalmaması ve farklı platformlarda sorunsuzca çalışabilmesi için Docker kullanıp arayüz olarak da Portainer'den yönetim sağlanmıştır 



## MikroServisler


🛒Basket: Redis yapısı sayesinde kullanıcıların alışveriş sepetlerini etkin bir şekilde yönetmelerine olanak tanır.


📦Cargo: MySQL kullanarak kargo süreçlerini ve ürün yönetimini etkin bir şekilde sağlamaya olanak tanır.


📮 Comment: PostgreSQL ile kullanıcıların yorum yapmasını sağlar.


📦Catalog: MongoDB ile ürünleri yönetir, listeleme işlemlerini gerçekleştirir ve veri dönüşümü için mapper kullanır.


🔒 IdentityServer: IdentityServer 4 ve OAuth2 kullanarak kimlik doğrulama ve yetkilendirme işlemlerini gerçekleştirir.


🌐 API Gateway: Mikroservislerin iletişimini yönetir, istekleri yönlendirir ve merkezi bir erişim noktası sağlar.



## Kullanılan Teknolojiler

**Backend Teknolojileri**

🤖 Asp.Net Core 8.0

🌐 Asp.Net Web API

💾 Dapper

🔒 IdentityServer4

📦 RabbitMQ

🌀 Ocelot Gateway

🪙 Json Web Token


**Veritabanı Teknolojileri**

🗃️ MSSQL

🗃️ MongoDb

🗃️ Redis

🗃️ PostgreSQL

**Altyapı ve Araçlar**

🐳 Docker

🖥️ DBeaver

🛠️ Postman

📝 Swagger

🚀 RapidApi




**Mimari ve Tasarım Desenleri**

🏛️ Onion Architecture

📜 CQRS Design Pattern

🎛️ Mediator Design Pattern

🗃️ Repository Design Pattern


**Frontend Teknolojileri**

🌐 Html

🎨 Css

💻 JavaScript

🧩 Bootstrap



**Öne Çıkan Özellikler**

📜 Tasarım Desenleri: CQRS, Mediator, Repository Design Pattern.

💾 Hafif ORM: Dapper.

🛒 Sepet Yönetimi: Redis ile kullanıcı sepet işlemleri.

🐳 Docker Entegrasyonu: Docker üzerinde çalışan Comment, Basket, Cargo, Order ve Identity mikroservisleri.

🔐 Ziyaretçi veya Kullanıcı Girişi: IdentityServer4 ile kimlik doğrulama.


