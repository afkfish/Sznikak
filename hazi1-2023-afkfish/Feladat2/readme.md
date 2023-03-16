# 2. Feladat megoldásának bemutatása

A feladatomban keszitettem egy IShape interface-t amit megvalosit az AreaText mert nem tud tobb ostol orokolni. Vna egy AShape abstract osztalyom amiben szerepelnek az IShape metodusainak abstract valtozatai es van egy ToString metodus feluliras.

A Circle es a Square osztaly orokol az AShape osztalytol es megvalositja a metodusokat tovabba felulirja azokat amik csak ra vonatkoznak. Emellett tartalmazzak a hozzajuk tartozo reszleteket is mint a kor sugara vagy a negyzet oldal hossza.

Letrehoztam egy ShapeContainer osztalyt is hogy legyen miben tarolni az alakzatokat. Ez az osztaly kezeli az alakzatok kiirasat is. Lehet belole torolni es lekerdezni tovabba belehelyezni ujjabb Shapeket ami barmilyen objektum lehet ami implementalja az IShape interface-t.
