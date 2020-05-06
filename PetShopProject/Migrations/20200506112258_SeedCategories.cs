﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PetShopProject.Migrations
{
    public partial class SeedCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 16);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "CategoryId", "Description", "Name", "PictureName" },
                values: new object[,]
                {
                    { 1, 2.3999999999999999, 1, "מוצאו של החתול הפרסי, או כפי שנקרא בזמנו, פשוט \"חתול ארוך שיער\", הוא בפרס ובארצות אסיה התיכונה. בספרות המקצועית הוזכר ה\"פרסי\" בפעם הראשונה ב-1876 בשם \"החתול האסיאתי\", אך כבר כ-300 שנה לפני כן, במאה השש עשרה, נראו חתולים אלה באירופה, בתחילה באיטליה וצרפת. לשם הגיעו על ידי דיפלומטים שביקרו בפרס וסביבתה, התלהבו ושלחו אותם לארצותיהם באירופה. בתקופה זו מוכרים חתולים ארוכי פרווה נוספים - חתולי האנגורה. מוצאם בטורקיה, והם אבות אבותיהם של החתולים מגזע ה-Turkish Angora. גם חתולים אלה הגיעו לארצות אירופה ובעיקר לאנגליה.", "חתול פרסי", "1_persian.jpg" },
                    { 2, 3.1000000000000001, 1, "החתול הבנגלי הוא גזע חדש יחסית. הגזע פותח להיות בעל אופי חברותי ויחד עם זאת להציג מראה של חתול פראי. אין להתבלבל עם טיגריס בנגלי שמו של החתול הבנגלי נגזר משם אבותיו חתול נמרי בנגלי (Prionailurus bengalensis). תחילתו של הגזע הייתה בשנת 1963 כאשר חוקר אמריקאי ערך מחקר בנושא לוקמיה של חתולים והרביע חתולי בר עם חתולי בית. משום שהרבעה זו היא עירוב בין שני מיני בעלי חיים שונים, הצאצאים של הדור הראשון היו לרוב עקרים. את הדור הראשון והשני מרביעים בדרך כלל עם חתול בית או חתולי בנגל אחרים. החתול נחשב חתול מהגזע הבנגלי כשהוא לפחות במרחק דור רביעי מחתול הבר האסיאתי.", "חתול בנגלי", "2_bangali.jpg" },
                    { 3, 6.0999999999999996, 1, "החתול הסיאמי הגיע מהמזרח הרחוק, שם גידלו וטיפחו אותו במקדשים הבודהיסטיים. חתולים אלו נחשבו כקדושים ואף האמינו כי הם גלגול של נשמות אדם. בתחילת המאה ה-20 הוא הובא לאנגליה, שם גידלו את הגזע בבתי גידול מיוחדים.", "חתול סיאמי", "3_siami.jpg" },
                    { 4, 1.6000000000000001, 1, "גופו של חתול הספינקס הוא בינוני ושרירי. יש לו זנב דק וארוך, ראש בגודל בינוני אוזניים גדולות ועיניים מלוכסנות. סימן ההיכר הבולט ביותר של גזע זה הוא היעדר הפרווה. עורו רך מאוד ועקב המחסור בפרווה, הוא רגיש מאוד לשינויי טמפרטורה ולכן זקוק לטיפוח אינטנסיבי.", "חתול ספינקס", "4_sphinx.jpg" },
                    { 5, 7.2000000000000002, 2, "במקור טופח הבולדוג במאה ה-17 באנגליה ללוחמת שוורים, מימי הביניים, במשך כ-600 שנה, הבולדוג שימש לגירוי וללחימה בשוורים. הייתה סברה, שגירוי השוורים לפני השחיטה תגרום לריכוך בשרם. לצורך כך היו משסים כלב בפר כבול או מותש. נוהג זה הפך ל\"ספורט\" פופולרי, שמשך קהל רב. מבנהו של הבולדוג, שפותח מגזע המסטיף, הפך אותו מתאים במיוחד לתפקיד: קצר רגליים, פראי, ובעל לסתות חזקות. פניו הקצרות הועילו גם כן, והוא יכול היה לנשוך את אפו של השור ברגע שזה הוריד את ראשו כדי לנגוח בכלב. הבולדוג לא היה מרפה גם כאשר השור היה מרים אותו לאוויר, ולעיתים גם היה נפצע בצורה קשה. בשנת 1835 הוצאה ההתגרות בפרים אל מחוץ לחוק. מאז נעלם כושר הלחימה של הבולדוג, והודגשו מבנה גופו ופניו המכווצים.", "בולדוג אנגלי", "5_buldog.jpg" },
                    { 6, 3.6000000000000001, 2, "הפודל נחשב לכלב השני האינטליגנטי ביותר, כשאת המקום הראשון תופס הבורדר קולי. בעוד שהבורדר קולי פעיל מאוד, הפודל שקט ורגוע בבית, אך אקטיבי ונמרץ בחוץ. הפודל חברותי ומסתדר היטב הן עם אנשים והן עם כלבים אחרים. פודלים מהסוגים הגדולים נחשבים לכלבי שמירה וציד טובים.", "פודל", "6_pudel.jpg" },
                    { 7, 2.0, 2, @"פאג (באנגלית: Pug) הוא כלב בעל פרצוף פחוס וגוף קטן. הפאג מוגדר ככלב לוויה. המילה ""פאג"" מגיעה כנראה מן המילה האנגלית Pugg, במובן של חיבה, שפירושה ""קופיף"" או ""שדון קטן"". שמות נוספים לכלב הפאג הם מופס, פוגו, קארלי, בולדוג הולנדי ומיני-מסטיף. לעיתים מתארים את הכלב כ""הרבה במעט"" (מלטינית multum in parvo) מה שבא לתאר את אופיו המקסים לעומת גודלו הקטן.
                לכלבי הפאג מבנה גוף קטן יחסית, עיניים גדולות ובולטות וזנבם מסולסל. פרוותו קצרה וצבעה שחור או חום בהיר עם פנים שחורות. רבים מהם סובלים מבעיות נשימה בגלל המבנה הפחוס של פניהם, בעיות עור בשל הקפלים בעורם ובפרוותם ומנשירה במהלך כל עונות השנה. הפאג הוא כלב ידידותי ומלא שמחה ואופיו נוח וידידותי למבוגרים ולילדים כאחד.", "פאג", "7_pug.jpg" },
                    { 8, 1.2, 2, "ההאסקים הסיביריים ידועים באופיים החברותי. הם שלווים, אוהבים ומסורים לבעלים. הם זן חכם ביותר ובעלי כושר הבנה מפותח ואינטליגנציה רגשית גבוהה. הם חברותיים מגיל צעיר ומתיידדים במיוחד עם ילדים, כך שהם כלבי משפחה אידיאליים. הם חיים מטבעם בלהקות ורגילים לעבודת צוות, ולכן מחשיבים את עצמם כחלק מהמשפחה.", "האסקי סיבירי", "8_haski.jpg" },
                    { 9, 2.8999999999999999, 3, "יען הוא סוג של עופות לא מעופפים ובו שני מינים. שני עופות אלה הם העופות הגדולים ביותר בעולם כיום: יען מצוי המגיע לגובה 2.6 מטר ולמשקל 130 ק\"ג ויען סומלי הקטן מעט ומגיע לאורך 200-240 ס\"מ ולמשקל 90-130 ק\"ג. בנוסף הם המהירים מכל העופות היבשתיים ובעלי הביצים הכבדות ביותר.", "יען", "9_yaen.jpg" },
                    { 10, 6.0999999999999996, 3, "פירוש מקור השם המדעי של היונה (Columba) הוא \"שחייה\". כך מתאר המחזאי היווני אריסטופאנס את היונה כשהיא נראית כ'שוחה' באוויר, ומכאן נלקח באופן מטאפורי השם האנגלי 'dove' שפירושו בגרמנית - 'צלילה'.", "יונה", "10_dove.jpg" },
                    { 11, 3.1000000000000001, 3, "קקדו לבן הוא מין של תוכי ממשפחת הקקדואיים, שנחשב לאחד התוכיים בעלי האינטליגנציה הגבוהה ביותר. הקקדו מכונה לעיתים \"אמברלה\" (מאנגלית: Umbrella, מטרייה) משום שכאשר הוא חש שמחה או פחד נפרשת מראשו מעיין כרבולת הדומה בצורתה למטרייה. קקדו לבן אנדמי לאיי מאלוקו הצפוניים, ותוחלת חייו הממוצעת היא 40 שנה.", "קקדו לבן", "11_kakado.jpg" },
                    { 12, 2.7999999999999998, 3, "לדררת קרמר יש גוף קטן. צבעה ירוק בהיר וזנבה ארוך, עם מדרגות. אורכה הממוצע הוא 41 סנטימטרים, מתוכם 23 סנטימטרים אורך זנבה. אורך כנפיה 15–17.5 סנטימטרים, ומוטת הכנפיים היא 34–39 סנטימטרים. חלקו העליון של מקורה אדום והתחתון שחור. לזכר הבוגר צווארון שחור בין הסנטר לצדי הצוואר. בעורף הוא נעשה ורוד בהיר. לצעירים יש נוצות זהבהבות, המקורים אדומים והזנב ארוך.", "דררת קרמר", "12_kremer.jpg" },
                    { 13, 1.5, 4, @"דג זהב או קָרַס זָהָב (שם מדעי: Carassius auratus) הוא דג ממשפחת הקרפיוניים (Cyprinidae), החי במים מתוקים. דג זה בוית למספר זנים ונפוץ כחיית מחמד באקווריומים ודג נוי בבריכות נוי.
                מקורו של דג הזהב שנוי במחלוקת בקרב הקהילה המדעית. התאוריה המקובלת כיום היא שדג הזהב הוא מוטציה גנטית של קרס מצוי (Carassius carassius). התאוריה נסמכת על העובדה כי לשני הדגים אותו מספר כרומוזומים, 100, בעוד שבשאר בני משפחת הקרפיוניים מספר הכרומוזומים הוא 50 בלבד.
                תאוריה נוספת רואה את מקור דג הזהב בקרפיון Carassius auratus gibelio.", "דג זהב", "13_gold.jpg" },
                    { 14, 2.2999999999999998, 4, "אמנוניים (בלעז: ציקלידים; שם מדעי: Cichlidae) היא משפחת דגים מסדרת הדקראים. משפחת האמנוניים גדולה ומגוונת, ומהווה חלק נכבד מסדרת הדקראים. קיימים לפחות 1,300 מינים שונים המתוארים באופן מדעי, ולאור זאת משפחת האמנוניים היא אחת ממערכת בעלי החוליות הגדולות ביותר. מספר רב של מינים חדשים מתגלה מדי שנה, ומינים רבים נשארים ללא תיאור. לכן מספר המינים הממשי לא ברור, והערכת מספרם נעה בין 1,300 ל-3,000 מינים.", "ציקליד אפריקאי", "14_afrika.jpg" },
                    { 15, 2.8999999999999999, 4, "דִּיסְקוּס (שם מדעי: Symphysodon) הוא שם של סוג ממשפחת האמנוניים הכולל שלושה מיני דגים, שמוצאם ממקווי מים מתוקים באגן האמזונאס. דגי הדיסקוס נפוצים מאוד כדגי נוי ונחשבים ליפים ויוקרתיים ביותר. הם מגודלים במספר מדינות ביבשת אסיה.", "דיסקוס", "15_diskus.png" },
                    { 16, 5.2000000000000002, 4, "מדובר בדג ממשפחת האמנוניים -Cichlidae, שמתאפיינים במבנה גוף דמוי דקר. דגים ממשפחה זו לרוב ניחנים באינטיליגנציה גבוהה ולעומת רוב בדגים שומרים על צאצאיהם בתקופת ההתפתחות. למשפחה תפוצה כלל עולמית באיזורים טרופיים וסובטרופיים, ובמקרים מסויימים מדובר במשפחת הדגים הדומיננטית באותו מקווה מים. משפחת האמנוניים, או בשמם העממי ציקלידים, כוללת לפחות 1650 זנים ידועים מה שהופך אותה לאחת ממשפחות החולייתנים הגדולות ביותר, ומהווה את משפחת הדגים הפופולארית ביותר בין דגי האקווריום.", "אלטום", "16_altom.jpg" }
                });
        }
    }
}
