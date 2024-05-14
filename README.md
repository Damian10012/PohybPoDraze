# PohybPoDraze
 
## Demonstrace vláken a pohybu ve Windows Forms pomocí C#
**Zadání:** Začátek bude v bodu A. Uživatel si bude moci vybrat jestli pojede do B nebo C. Auta můžou mít různou rychlost a nesmějí se srazit.

**Implementace:** Každé auto běží na vlastním vlákně. Kontroluje se vzdálenost mezi jednotlivými auty v listu a pokud jsou moc blízko, nastaví se dočasně rychlost zadního auta na rychlost auta předního. Rychlost funguje principem snižování čekání vlákna. Základní délka čekání je 60ms, maximální efektivní rychlost je 20 -> minimální doba čekání je 10ms.
