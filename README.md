
# 🧮 RPN Calculator with Undo/Redo, Expression Tree & Queue

![Language](https://img.shields.io/badge/language-C%23-blue.svg)
![Platform](https://img.shields.io/badge/platform-Windows%20Forms-brightgreen.svg)
![Status](https://img.shields.io/badge/status-Completed-success.svg)

---

## 📘 Proje Özeti

Bu proje, **Veri Yapıları** dersine ait bir uygulama projesidir. Temel amacı, postfix (ters lehçe) ifadelerin işlenmesini sağlayan bir hesap makinesi geliştirmektir. Ayrıca projede çeşitli veri yapıları entegre edilerek geri alma/ileri alma (Undo/Redo), ifade ağacı (Expression Tree) ve kuyruk (Queue) simülasyonu gibi yetenekler kazandırılmıştır.

---

## 🎯 Proje Amacı

- Postfix ifadelerin işlenmesi (RPN - Reverse Polish Notation)
- Geri alma / ileri alma işlemlerinin desteklenmesi (Undo-Redo)
- İfadelerin ağaç yapısıyla görselleştirilmesi (Expression Tree)
- İşlem sırasını simüle eden bir kuyruk sistemi (Queue)

---

## 👨‍👩‍👦 Grup Üyeleri

| Adı Soyadı | GitHub Kullanıcısı | Sorumluluğu |
|------------|--------------------|--------------|
| Gökay Goncagül    | [@GkyG](https://github.com/GkyG) | Undo/Redo Algoritması ve GUI Tasarımı,Stack İşlemlerinin yapılması, Expression Tree'nin oluşturulması, Queue yapısı & dökümantasyon |

> Tüm çalışmalar `dev` isimli ortak branch üzerinden yapılmıştır. Proje gelişimi boyunca commit ve merge işlemleri GitHub üzerinden takip edilmiştir.

---

## 🧱 Kullanılan Veri Yapıları

| Veri Yapısı   | Kullanım Alanı | Açıklama |
|---------------|----------------|----------|
| **Stack**     | RPN çözümlemesi | Postfix işlemlerde operand ve operatör yönetimi |
| **Linked List** | Undo/Redo işlemleri | Geri ve ileri adımların yönetimi için çift yönlü yapı |
| **Binary Tree** | Expression Tree | Matematiksel ifadelerin hiyerarşik gösterimi |
| **Queue**     | İşlem sıralama | Kullanıcının sıraya aldığı işlemlerin toplu yürütülmesi |

---

## 🖼️ Arayüz Görselleri

| RPN Hesaplama | Expression Tree |
|---------------|-----------------|
| ![RPN Calculator GUI](images/GUIYapısı_Temel_islemler.PNG) | ![Expression Tree](images/ExampleExpressionTree.PNG) |

> Görseller demo çalıştırmasından alınmıştır.

---

## ⚙️ Özellik Listesi

- ✅ Postfix (RPN) çözümleme
- ✅ Undo / Redo mekanizması
- ✅ Ağaç yapısında ifade görselleştirme
- ✅ Kuyruk (Queue) ile toplu işlem çalıştırma
- ✅ Dinamik arayüz, kullanıcı dostu tasarım
- ✅ Hata kontrol mekanizmaları

---

## 📊 Algoritma Analizi

### 🔁 Stack vs Array
- Array sabit boyuttadır, fakat Stack dinamik büyür.
- Stack üzerinde `Push`, `Pop` işlemleri amortize olarak `O(1)` karmaşıklıktadır.
- Toplam işlem: her token sadece bir kez işlenir → O(N)

Karmaşıklık:

T(N)=N⋅O(1)=O(N)

### 🔄 Linked List ile Undo/Redo
- Geri alma: `O(1)` – önceki node’a referans
- İleri alma: `O(1)` – sonraki node’a referans
- Eklemeler/silmeler için ekstra kaydırma gerektirmez
- şlem Adımları:

AddLast, RemoveLast işlemleri → O(1)

RebuildStack() → geçmişteki tüm işlemleri yeniden uygular → O(N)

Karmaşıklık:

Undo/Redo:O(1),RebuildStack:O(N)


### 🌲 Expression Tree
- Operatörler düğüm (node), operandlar yaprak (leaf)
- Derinlik sıraları: infix, postfix, prefix gösterim
- Tree traversal: `O(n)` karmaşıklık
-🧮 Matematiksel Doğrulama:
Bir ağacın zaman karmaşıklığını tanımlamak için aşağıdaki bağıntıyı kullanalım:

𝑇(𝑁)=𝑇(𝐿)+𝑇(𝑅)+C

T(L): Sol alt ağacın dolaşım zamanı
T(R): Sağ alt ağacın dolaşım zamanı
C: Mevcut düğümü ziyaret etmek için sabit süre

Eğer ağacımız sağa eğimli (right-skewed) bir ağaçsa, sol taraf boş kalır, yani 
L=0. Bu durumda:
T(N)=T(0)+T(N−1)+C
Açalım:

T(N)=T(0)+T(N−1)+C
T(N)=T(0)+T(N−2)+2C
T(N)=T(0)+T(N−3)+3C
⋮
T(N)=NT(0)+NC=O(N)

✅ Sonuç:
İfade ağacı üzerinde yapılan tüm dolaşım algoritmaları (preorder, inorder, postorder) her düğümü bir kez ziyaret ettiği için zaman karmaşıklığı:

O(N)
​


### ⏳ Queue (FIFO)
- `Enqueue`: sıraya ekleme `O(1)`
- `Dequeue`: sıradan çıkarma `O(1)`
- RPN işlemleri sırayla yürütülerek hata yönetimi sağlanır
- Karmaşıklık (M işlem için):

T(M)=M⋅O(N)

---

## 🧪 Test Durumu

| Özellik | Durum |
|---------|-------|
| RPN çözümleme | ✅ Başarılı |
| Undo/Redo | ✅ Sorunsuz çalışıyor |
| TreeView gösterimi | ✅ Doğru yapı gösterimi |
| Kuyruk işlemleri | ✅ Doğru sırayla işlem |
| Exception handling | ✅ Hatalı girişler engelleniyor |
| Build & .exe çalıştırma | ✅ Çalıştırılabilir dosya üretildi |

---

## 🚀 Kurulum ve Çalıştırma

### 1. Projeyi klonlayın
```bash
git clone https://github.com/kullaniciadi/rpn-calculator.git
cd rpn-calculator
```

### 2. Visual Studio ile açın
- `RpnCalculator.sln` dosyasını açın
- Build Configuration: `Release` olarak seçin
- `Ctrl + Shift + B` ile derleyin

### 3. `.exe` çalıştırın
- `bin/Release/` klasöründe çalıştırılabilir dosya yer alır

---

## 📦 Dağıtım

Projeyi `.exe` dosyasına dönüştürmek için:
- Visual Studio'da `Release` moduna geçin
- `Build > Build Solution` adımlarını izleyin
- `bin/Release/` klasöründe `.exe` oluşur

> İsteğe bağlı olarak Dockerfile da hazırlanabilir.

---

## 📚 Kaynaklar

- [Visual Studio Documentation](https://learn.microsoft.com/en-us/visualstudio/)
- [RPN Wiki](https://en.wikipedia.org/wiki/Reverse_Polish_notation)
- [GitHub Workflow Video](https://www.youtube.com/watch?v=jhtbhSpV5YA)

---

## 📝 Lisans

MIT Lisansı altında paylaşılmıştır. Detaylar için `LICENSE` dosyasına bakınız.

---

> **Not:** Bu proje, tamamen özgün olarak geliştirilmiştir.
