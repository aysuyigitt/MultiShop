
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



## Öne Çıkan Özellikler

📜 Tasarım Desenleri: CQRS, Mediator, Repository Design Pattern.

💾 Hafif ORM: Dapper.

🛒 Sepet Yönetimi: Redis ile kullanıcı sepet işlemleri.

🐳 Docker Entegrasyonu: Docker üzerinde çalışan Comment, Basket, Cargo, Order ve Identity mikroservisleri.

🔐 Ziyaretçi veya Kullanıcı Girişi: IdentityServer4 ile kimlik doğrulama.

## Resimler

![TrendKıyafetler](https://github.com/user-attachments/assets/086103d1-8ba3-42ad-b18b-87e537c1a993)






![ÖneÇıkanKategori](https://github.com/user-attachments/assets/598c61ee-e1e1-40ce-94d7-222143197c40)





![öneÇıkanÜrün](https://github.com/user-attachments/assets/d9113ddf-fab5-40f9-81f2-59b8adcc9f80)





![Kategori](https://github.com/user-attachments/assets/a3392cfa-bc05-4f56-be53-a7da0336b777)





![MyOrder](https://github.com/user-attachments/assets/0a57304e-a729-4c70-99a1-6c308a78c831)





![Pay](https://github.com/user-attachments/assets/7eb01594-8479-47b2-94b9-4cb349f00d70)





![Yorum](https://github.com/user-attachments/assets/53bdf7a0-58fa-40c7-9748-8473994d5606)






![docker](https://github.com/user-attachments/assets/a4c5bd35-fc38-42e2-9768-5f023420c02a)





