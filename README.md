# Dagboksappen

Du kan köra denna app genom att:
- Klona detta repo
- Kör kommandot (i mappen du klona repot i) 'dotnet run --project="DiaryApp/" ' 

Input görs genom menyn och funktionerna som appen har, och output finns för att visa användaren att appen har gjort aktionen dem förväntar.

För menyn användes switch-cases eftersom logiken för den är mycket simpel och kräver inget från if-statements som switch-cases inte har. DateTime användes för DiaryEntry.Date då det gjorde klassen som enklast och behövs den konverteras för någon anledning kan det göras i den metoden/funktionen. 
Felhanteringen i menyn var enkel då jag kunde definera dem förväntade inputen och sätta en default ifall ett oväntat input skulle åstakomma. Felhanteringen inom metoder sker genom if statements som kollar om möjliga inputs (som programmet annars inte skulle kunna hantera) har upstått och sedan ge den instruktioner för hur att bära sig åt. Felhanteringen när det kom till sökmetoden gjordes genom att köra koden inom try och sedan catcha erroret och printa det tillbaka till användaren innan en early return. 