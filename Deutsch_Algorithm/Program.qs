namespace Deutsch_Algorithm {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;

    // Uf (Oracle) fonksiyonunu temsil eden kuantum kapıları
    operation DeutschOracle(fType : Int, x : Qubit, y : Qubit) : Unit is Adj + Ctl {
        if fType == 0 { 
            // Sabit fonksiyon (f(0) = 0, f(1) = 0) => y değişmez
        } 
        elif fType == 1 { 
            // Sabit fonksiyon (f(0) = 1, f(1) = 1) => y her zaman 1 olur
            X(y);
        } 
        elif fType == 2 { 
            // Dengeli fonksiyon (f(0) = 0, f(1) = 1) => CNOT kapısı uygula
            CNOT(x, y);
        } 
        elif fType == 3 { 
            // Dengeli fonksiyon (f(0) = 1, f(1) = 0) => CNOT + X uygula
            CNOT(x, y);
            X(y);
        }
    }

    @EntryPoint()
    operation RunDeutschAlgorithm() : Unit {
        use x = Qubit();
        use y = Qubit();

        // Başlangıç durumu |x⟩ = |0⟩ ve |y⟩ = |0⟩
        X(y); // y'yi |1⟩ durumuna getir
        H(x);
        H(y);

        // Uf Kapısını Uygula (örneğin fType = 3: Dengeli fonksiyon)
        let fType = 1; 
        DeutschOracle(fType, x, y);

        // Tekrar Hadamard Kapısı Uygula
        // 0 0 ile başladık ftype 0 olduğunda x 0 y 1 oldu sonra süperpozisyona girdi daha sonra h(x) ile tekrar x ilk değerini aldı kural bu. yani x 0 oldu
        //ftype 1 olduğunda x 0 y 1 sonra x 0 y 0 x yine kesin olarak 0 oldu ve ilk değerini aldı 
        H(x);

        let result = M(x);
        if result == Zero {
            Message("Fonksiyon SABİTTİR.");
        } 
        else {
            Message("Fonksiyon DENGELİDİR.");
        }

        Reset(x);
        Reset(y);
        // h(x) fonksiyonu iki kere çağrıldığında süperpozisyondan çıkar ve ilk değerini alır.
        //CNOT(x,y)  x=1 ise y yi çevirir x=0 ise y değişmez
    }
}