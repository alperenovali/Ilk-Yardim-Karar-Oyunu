# 🩹 Doğru Karar, Hayat Kurtarır! (Right Decision, Saves Lives)

![Unity](https://img.shields.io/badge/Unity-2022.3%2B-black?style=flat&logo=unity)
![Platform](https://img.shields.io/badge/Platform-WebGL-blue)
![Status](https://img.shields.io/badge/Status-In%20Development-orange)

> **TÜBİTAK 2209-A Üniversite Öğrencileri Araştırma Projeleri** kapsamında desteklenmektedir.

## 📖 Proje Hakkında

Bu proje, acil durumlarda bireylerin karar verme süreçlerini analiz etmek amacıyla geliştirilmiş **oyunlaştırılmış bir veri toplama sistemidir**. Klasik eğitimlerin aksine, katılımcıların teorik bilgilerini **stres altında ve zaman kısıtlamasıyla** nasıl pratiğe döktüklerini ölçmeyi hedefler.

Oyun, Unity oyun motoru kullanılarak WebGL tabanlı geliştirilmiştir ve tarayıcı üzerinden erişilebilir.

### 🎯 Ana Hedefler
* **Veri Toplama:** Kullanıcıların kriz anındaki kararlarını (Doğru/Kısmen Doğru/Yanlış) ve reaksiyon sürelerini ölçmek.
* **Eğitim:** Oyun sonunda kişiye özel geri bildirimlerle ilk yardım farkındalığını artırmak.
* **Analiz:** Toplanan anonim verilerle toplumdaki bilgi eksikliklerini ve davranışsal hataları tespit etmek.

---

## 🛠️ Teknik Altyapı ve Özellikler

Proje, genişletilebilir ve modüler bir yapıda tasarlanmıştır. "Clean Architecture" ve "Singleton" tasarım desenleri kullanılarak yönetilebilir bir kod tabanı oluşturulmuştur.

### Kullanılan Teknolojiler
| Teknoloji | Kullanım Amacı |
| :--- | :--- |
| **Unity Engine (2D)** | Oyun motoru ve görselleştirme. |
| **C#** | Scripting ve oyun mantığı. |
| **ScriptableObjects** | Senaryo verilerinin (Görsel, Ses, Metin) modüler yönetimi. |
| **WebGL** | Platform bağımsız tarayıcı desteği. |

### Temel Özellikler
* **ScriptableObject Tabanlı Senaryo Sistemi:** Kod yazmadan yeni senaryo ve diyalog ekleyebilme esnekliği.
* **Stack (Yığın) Tabanlı Navigasyon:** Kullanıcının geçmiş adımlara dönebilmesini sağlayan hafıza sistemi.
* **Gelişmiş Ses Yönetimi:** `AudioMixer` entegrasyonu ile Müzik, SFX ve Dublaj kanallarının ayrıştırılması ve kontrolü.
* **Ayarlar Paneli:** Ses seviyesi kontrolü ve Dinamik Dil Altyapısı (TR/EN desteği).
* **Singleton Manager Yapısı:** `GameManager`, `AudioManager` ve `SettingsManager` ile merkezi yönetim.

---

## 📂 Dosya Yapısı

Proje dosyaları, geliştirme sürecinde karmaşıklığı önlemek adına türüne göre (Type-Based) ayrılmıştır:

```text
Assets/
├── Art/           # UI elementleri, arka planlar ve senaryo çizimleri
├── Audio/         # Müzik, ses efektleri (SFX) ve dublaj dosyaları
├── Data/          # ScriptableObject veri dosyaları (Senaryo adımları burada tutulur)
├── Fonts/         # Proje genelinde kullanılan font dosyaları
├── Prefabs/       # Tekrar kullanılabilir oyun objeleri (Managers, UI Sistemleri)
├── Scenes/        # Oyun sahneleri (Ana Menü, Senaryo Sahneleri)
└── Scripts/       # Tüm C# kodları (Core, Managers, UI, ScriptableObjects)