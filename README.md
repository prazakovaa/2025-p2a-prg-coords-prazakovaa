# 2025-p2a-prg-coords-prazakovaa

Toto cvičení se věnuje praktickému použití rozhraní (IEquatable<Coord>, IComparable<Coord>). Trošku předbíháme, protože obě rozhraní jsou generická, což by ale mělo celou věc usnadnit.

Vytvořte vlastní implementaci třídy pro evidenci souřadnic ve dvourozměrném prostoru tak, aby:

1. bylo možné určit, které souřadnice jsou totožné přes metodu Equals() a operátory == a !=.
2. bylo možné určit, která souřadnice je dále od počátku souřadného systému přes operace porovnávání.
3. bylo možné souřadnice sčítat s tím, že výsledkem bude nová souřadnice vzniklá součtem hodnot jejich dimenzí
4. bylo možné vynásobit souřadnici jedním číslem, kde výsledkem bude nová souřadnice vzniklá vynásobením obou dimenzí tímto číslem


##Rozbor

Základ třídy je jednoduchý: máme dvě souřadnice a nic navíc.

Když ale zkusíme porovnávat, nedopadne to úplně podle našich očekávání.
Je to proto, že porovnání tříd se děje přes reference a každý objekt leží na jiné adrese.
Porovnání mezi třídami se děje pomocí rozhraní IEquatable<T>. Generický typ zde uvádí to, s jakým typem porovnání provádíme.
Porovnání přes operátory == a != je potřeba udělat přes přetížení operátorů.

Porovnání je potřeba realizovat přes přetížené operátory < a >.
S tím nám může pomocí rozhraní IComparable<T>.
Bude také potřeba určit metriku velikosti souřadnice.
