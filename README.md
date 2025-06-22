# 📱📍 Tarihi Yapılar AR Uygulaması

## 📌 Proje Açıklaması

**Tarihi Yapılar AR**, mobil cihazlarda çalışan, artırılmış gerçeklik (AR) teknolojisi ile desteklenmiş bir eğitim ve kültür uygulamasıdır. Uygulama sayesinde kullanıcılar, harita üzerinde gözüken tarihi yapıları keşfedebilir, bu yapılara tıklayarak bilgi alabilir ve 3 boyutlu modellerini gerçek dünyada görüntüleyebilir.

### 🎯 Projenin Amacı ve Hedef Kitlesi

- **Amaç:** Kültürel mirasımızı dijital ortamda tanıtmak ve öğrenmeyi daha interaktif hale getirmek.
- **Hedef Kitle:** Turistler, öğrenciler, öğretmenler ve kültürel mirasa ilgi duyan herkes.

### 🧰 Kullanılan Teknolojiler ve Framework'ler

- **Unity 6.0**
- **AR Foundation (Unity)**
- **ARCore / ARKit**
- **C# (scripting dili)**
- **Blender / Sketchfab (3D modeller için)**

---

## 🛠️ Kurulum Rehberi

### 🔧 Gerekli Yazılımlar

- **Unity Hub ve Unity Editor (2021.3 veya üzeri)**
- **Android Studio (Android için) veya Xcode (iOS için)**
- **Mobil cihaz (ARCore veya ARKit destekli)**

### 🔗 Bağımlılıklar

- `AR Foundation` paketi
- `ARKit XR Plugin` veya `ARCore XR Plugin`
- `Maps SDK` (isteğe bağlı)
- `TextMeshPro` (bilgi metinleri için)

### 📥 Kurulum Adımları

1. Unity Hub'dan 2021.3 veya üzeri bir sürüm indirin.
2. Yeni bir 3D proje oluşturun.
3. `AR Foundation`, `ARCore/ARKit`, `TextMeshPro` ve harita SDK'larını `Package Manager` üzerinden kurun.
4. Projeyi mobil platform için (Android/iOS) yapılandırın.
5. `Scenes` klasörü altında bir ana sahne oluşturun.
6. `Assets/Models` klasörüne 3D tarihi yapı modellerini ekleyin.
7. `AR Session`, `AR Session Origin`, `AR Camera` objelerini sahneye ekleyin.
8. Uygulamayı cihazda test edin.

---

## ▶️ Kullanım Talimatları

1. Uygulama açıldığında cihaz kamerası devreye girer.
2. Harita üzerinden bir tarihi yapıya tıklayın.
3. Ekranda yapı hakkında kısa bir bilgi metni görüntülenir.
4. Ardından AR modül aktive olur ve yapı modeli bulunduğunuz ortama yerleştirilir.
5. Kullanıcı modeli döndürebilir, büyütüp küçültebilir.

### 🧩 Temel Özellikler

- Canlı harita üzerinde yapı seçimi
- Bilgi kartı gösterimi
- 3B model görüntüleme ve etkileşim
- Çoklu yapı desteği

---

## 🧠 AR Özellikleri

### Kullanılan Teknolojiler

- **AR Foundation**: Platformlar arası AR desteği sağlar.
- **ARCore (Android) / ARKit (iOS)**: Cihazların AR desteği için kullanılır.
- **Plane Detection & Hit Test**: Yüzey algılama ve model yerleştirme.
- **3D Model Renderer**: Yapıların gerçek dünya ortamında gösterilmesini sağlar.

### Donanım Gereksinimi

- ARCore destekli Android cihaz
- Cihazda kamera izni verilmiş olmalı

---

## 🖼️ Ekran Görüntüleri

> Aşağıdaki bölüme en az 5 ekran görüntüsü eklemelisin (şu an örnek olarak açıklamalar ekliyorum):

![WhatsApp Görsel 2025-06-22 saat 23 40 32_eebc7e4d](https://github.com/user-attachments/assets/6ad18516-1162-4c8d-afd5-ed8ffd58fb35)
![WhatsApp Görsel 2025-06-22 saat 23 40 32_eb22b5b2](https://github.com/user-attachments/assets/3de71e36-d015-4937-8e5a-803bc5ada8d5)
![WhatsApp Görsel 2025-06-22 saat 23 40 32_7a2f4301](https://github.com/user-attachments/assets/c5ffc05b-7751-4b8f-8e98-67cd4e78faae)
![WhatsApp Görsel 2025-06-22 saat 23 40 32_feab0451](https://github.com/user-attachments/assets/f05e3987-6940-41aa-b9d2-9632e94e5d00)
