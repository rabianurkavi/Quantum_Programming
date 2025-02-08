namespace Deutsch_Algorithm {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    

  // Uf (Oracle) fonksiyonunu temsil eden kuantum kapıları
    operation DeutschOracle(fType : Int, x : Qubit, y : Qubit) : Unit is Adj + Ctl {
        if (fType == 0) { 
            // Sabit fonksiyon (f(0) = 0, f(1) = 0) => y değişmez
        } 
        elif (fType == 1) { 
            // Sabit fonksiyon (f(0) = 1, f(1) = 1) => y her zaman 1 olur
            X(y);
        } 
        elif (fType == 2) { 
            // Dengeli fonksiyon (f(0) = 0, f(1) = 1) => CNOT kapısı uygula
            CNOT(x, y);
        } 
        elif (fType == 3) { 
            // Dengeli fonksiyon (f(0) = 1, f(1) = 0) => CNOT + X uygula
            CNOT(x, y);
            X(y);
        }
    }

    @EntryPoint()
    operation RunDeutschAlgorithm() : Unit {
        using (x = Qubit()) {
            using (y = Qubit()) {
                // Başlangıç durumu |x⟩ = |0⟩ ve |y⟩ = |1⟩
                X(y); // y'yi |1⟩ durumuna getir
                H(x);
                H(y);

                // Uf Kapısını Uygula (örneğin fType = 2: Dengeli fonksiyon)
                let fType = 3; 
                DeutschOracle(fType, x, y);

                // Tekrar Hadamard Kapısı Uygula
                H(x);

                
                let result = M(x);
                if (result == Zero) {
                    Message("Fonksiyon SABİTTİR.");
                } 
                else {
                    Message("Fonksiyon DENGELİDİR.");
                }

                // Qubit'leri sıfırla
                Reset(x);
                Reset(y);
            }
        }
    }
}

