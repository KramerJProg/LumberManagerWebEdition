using Microsoft.EntityFrameworkCore.Migrations;

namespace LumberManagerWebEdition.Data.Migrations
{
    public partial class ProductSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "BoardFeet", "Height", "Length", "OnHand", "Sold", "Width" },
                values: new object[,]
                {
                    { 1, 1109, (byte)2, (byte)8, (short)0, (short)0, (byte)4 },
                    { 330, 768, (byte)6, (byte)8, (short)0, (short)0, (byte)8 },
                    { 329, 1920, (byte)6, (byte)20, (short)0, (short)0, (byte)6 },
                    { 328, 1728, (byte)6, (byte)18, (short)0, (short)0, (byte)6 },
                    { 327, 1536, (byte)6, (byte)16, (short)0, (short)0, (byte)6 },
                    { 326, 1344, (byte)6, (byte)14, (short)0, (short)0, (byte)6 },
                    { 325, 1152, (byte)6, (byte)12, (short)0, (short)0, (byte)6 },
                    { 324, 960, (byte)6, (byte)10, (short)0, (short)0, (byte)6 },
                    { 323, 768, (byte)6, (byte)8, (short)0, (short)0, (byte)6 },
                    { 322, 2160, (byte)3, (byte)20, (short)0, (short)0, (byte)12 },
                    { 321, 1944, (byte)3, (byte)18, (short)0, (short)0, (byte)12 },
                    { 320, 1728, (byte)3, (byte)16, (short)0, (short)0, (byte)12 },
                    { 319, 1512, (byte)3, (byte)14, (short)0, (short)0, (byte)12 },
                    { 331, 960, (byte)6, (byte)10, (short)0, (short)0, (byte)8 },
                    { 318, 1296, (byte)3, (byte)12, (short)0, (short)0, (byte)12 },
                    { 316, 864, (byte)3, (byte)8, (short)0, (short)0, (byte)12 },
                    { 315, 2250, (byte)3, (byte)20, (short)0, (short)0, (byte)10 },
                    { 314, 2025, (byte)3, (byte)18, (short)0, (short)0, (byte)10 },
                    { 313, 1800, (byte)3, (byte)16, (short)0, (short)0, (byte)10 },
                    { 312, 1575, (byte)3, (byte)14, (short)0, (short)0, (byte)10 },
                    { 311, 1350, (byte)3, (byte)12, (short)0, (short)0, (byte)10 },
                    { 310, 1125, (byte)3, (byte)10, (short)0, (short)0, (byte)10 },
                    { 309, 900, (byte)3, (byte)8, (short)0, (short)0, (byte)10 },
                    { 308, 2160, (byte)3, (byte)20, (short)0, (short)0, (byte)8 },
                    { 307, 1944, (byte)3, (byte)18, (short)0, (short)0, (byte)8 },
                    { 306, 1728, (byte)3, (byte)16, (short)0, (short)0, (byte)8 },
                    { 305, 1512, (byte)3, (byte)14, (short)0, (short)0, (byte)8 },
                    { 317, 1080, (byte)3, (byte)10, (short)0, (short)0, (byte)12 },
                    { 304, 1296, (byte)3, (byte)12, (short)0, (short)0, (byte)8 },
                    { 332, 1152, (byte)6, (byte)12, (short)0, (short)0, (byte)8 },
                    { 334, 1536, (byte)6, (byte)16, (short)0, (short)0, (byte)8 },
                    { 360, 1536, (byte)2, (byte)12, (short)0, (short)0, (byte)6 },
                    { 359, 1280, (byte)2, (byte)10, (short)0, (short)0, (byte)6 },
                    { 358, 1024, (byte)2, (byte)8, (short)0, (short)0, (byte)6 },
                    { 357, 2773, (byte)2, (byte)20, (short)0, (short)0, (byte)4 },
                    { 356, 2496, (byte)2, (byte)18, (short)0, (short)0, (byte)4 },
                    { 355, 2219, (byte)2, (byte)16, (short)0, (short)0, (byte)4 },
                    { 354, 1941, (byte)2, (byte)14, (short)0, (short)0, (byte)4 },
                    { 353, 1664, (byte)2, (byte)12, (short)0, (short)0, (byte)4 },
                    { 352, 1387, (byte)2, (byte)10, (short)0, (short)0, (byte)4 },
                    { 351, 1109, (byte)2, (byte)8, (short)0, (short)0, (byte)4 },
                    { 350, 1920, (byte)6, (byte)20, (short)0, (short)0, (byte)12 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "BoardFeet", "Height", "Length", "OnHand", "Sold", "Width" },
                values: new object[,]
                {
                    { 349, 1728, (byte)6, (byte)18, (short)0, (short)0, (byte)12 },
                    { 333, 1344, (byte)6, (byte)14, (short)0, (short)0, (byte)8 },
                    { 348, 1536, (byte)6, (byte)16, (short)0, (short)0, (byte)12 },
                    { 346, 1152, (byte)6, (byte)12, (short)0, (short)0, (byte)12 },
                    { 345, 960, (byte)6, (byte)10, (short)0, (short)0, (byte)12 },
                    { 344, 768, (byte)6, (byte)8, (short)0, (short)0, (byte)12 },
                    { 343, 2000, (byte)6, (byte)20, (short)0, (short)0, (byte)10 },
                    { 342, 1800, (byte)6, (byte)18, (short)0, (short)0, (byte)10 },
                    { 341, 1600, (byte)6, (byte)16, (short)0, (short)0, (byte)10 },
                    { 340, 1400, (byte)6, (byte)14, (short)0, (short)0, (byte)10 },
                    { 339, 1200, (byte)6, (byte)12, (short)0, (short)0, (byte)10 },
                    { 338, 1000, (byte)6, (byte)10, (short)0, (short)0, (byte)10 },
                    { 337, 800, (byte)6, (byte)8, (short)0, (short)0, (byte)10 },
                    { 336, 1920, (byte)6, (byte)20, (short)0, (short)0, (byte)8 },
                    { 335, 1728, (byte)6, (byte)18, (short)0, (short)0, (byte)8 },
                    { 347, 1344, (byte)6, (byte)14, (short)0, (short)0, (byte)12 },
                    { 303, 1080, (byte)3, (byte)10, (short)0, (short)0, (byte)8 },
                    { 302, 864, (byte)3, (byte)8, (short)0, (short)0, (byte)8 },
                    { 301, 2160, (byte)3, (byte)20, (short)0, (short)0, (byte)6 },
                    { 269, 576, (byte)3, (byte)12, (short)0, (short)0, (byte)8 },
                    { 268, 480, (byte)3, (byte)10, (short)0, (short)0, (byte)8 },
                    { 267, 384, (byte)3, (byte)8, (short)0, (short)0, (byte)8 },
                    { 266, 960, (byte)3, (byte)20, (short)0, (short)0, (byte)6 },
                    { 265, 864, (byte)3, (byte)18, (short)0, (short)0, (byte)6 },
                    { 264, 768, (byte)3, (byte)16, (short)0, (short)0, (byte)6 },
                    { 263, 672, (byte)3, (byte)14, (short)0, (short)0, (byte)6 },
                    { 262, 576, (byte)3, (byte)12, (short)0, (short)0, (byte)6 },
                    { 261, 480, (byte)3, (byte)10, (short)0, (short)0, (byte)6 },
                    { 260, 384, (byte)3, (byte)8, (short)0, (short)0, (byte)6 },
                    { 259, 1040, (byte)3, (byte)20, (short)0, (short)0, (byte)4 },
                    { 258, 936, (byte)3, (byte)18, (short)0, (short)0, (byte)4 },
                    { 270, 672, (byte)3, (byte)14, (short)0, (short)0, (byte)8 },
                    { 257, 832, (byte)3, (byte)16, (short)0, (short)0, (byte)4 },
                    { 255, 624, (byte)3, (byte)12, (short)0, (short)0, (byte)4 },
                    { 254, 520, (byte)3, (byte)10, (short)0, (short)0, (byte)4 },
                    { 253, 416, (byte)3, (byte)8, (short)0, (short)0, (byte)4 },
                    { 252, 2240, (byte)4, (byte)20, (short)0, (short)0, (byte)12 },
                    { 251, 2016, (byte)4, (byte)18, (short)0, (short)0, (byte)12 },
                    { 250, 1792, (byte)4, (byte)16, (short)0, (short)0, (byte)12 },
                    { 249, 1568, (byte)4, (byte)14, (short)0, (short)0, (byte)12 },
                    { 248, 1344, (byte)4, (byte)12, (short)0, (short)0, (byte)12 },
                    { 247, 1120, (byte)4, (byte)10, (short)0, (short)0, (byte)12 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "BoardFeet", "Height", "Length", "OnHand", "Sold", "Width" },
                values: new object[,]
                {
                    { 246, 896, (byte)4, (byte)8, (short)0, (short)0, (byte)12 },
                    { 245, 2333, (byte)4, (byte)20, (short)0, (short)0, (byte)10 },
                    { 244, 2100, (byte)4, (byte)18, (short)0, (short)0, (byte)10 },
                    { 256, 728, (byte)3, (byte)14, (short)0, (short)0, (byte)4 },
                    { 271, 768, (byte)3, (byte)16, (short)0, (short)0, (byte)8 },
                    { 272, 864, (byte)3, (byte)18, (short)0, (short)0, (byte)8 },
                    { 273, 960, (byte)3, (byte)20, (short)0, (short)0, (byte)8 },
                    { 300, 1944, (byte)3, (byte)18, (short)0, (short)0, (byte)6 },
                    { 299, 1728, (byte)3, (byte)16, (short)0, (short)0, (byte)6 },
                    { 298, 1512, (byte)3, (byte)14, (short)0, (short)0, (byte)6 },
                    { 297, 1296, (byte)3, (byte)12, (short)0, (short)0, (byte)6 },
                    { 296, 1080, (byte)3, (byte)10, (short)0, (short)0, (byte)6 },
                    { 295, 864, (byte)3, (byte)8, (short)0, (short)0, (byte)6 },
                    { 294, 2340, (byte)3, (byte)20, (short)0, (short)0, (byte)4 },
                    { 293, 2106, (byte)3, (byte)18, (short)0, (short)0, (byte)4 },
                    { 292, 1872, (byte)3, (byte)16, (short)0, (short)0, (byte)4 },
                    { 291, 1638, (byte)3, (byte)14, (short)0, (short)0, (byte)4 },
                    { 290, 1404, (byte)3, (byte)12, (short)0, (short)0, (byte)4 },
                    { 289, 1170, (byte)3, (byte)10, (short)0, (short)0, (byte)4 },
                    { 288, 936, (byte)3, (byte)8, (short)0, (short)0, (byte)4 },
                    { 287, 960, (byte)3, (byte)20, (short)0, (short)0, (byte)12 },
                    { 286, 864, (byte)3, (byte)18, (short)0, (short)0, (byte)12 },
                    { 285, 768, (byte)3, (byte)16, (short)0, (short)0, (byte)12 },
                    { 284, 672, (byte)3, (byte)14, (short)0, (short)0, (byte)12 },
                    { 283, 576, (byte)3, (byte)12, (short)0, (short)0, (byte)12 },
                    { 282, 480, (byte)3, (byte)10, (short)0, (short)0, (byte)12 },
                    { 281, 384, (byte)3, (byte)8, (short)0, (short)0, (byte)12 },
                    { 280, 1000, (byte)3, (byte)20, (short)0, (short)0, (byte)10 },
                    { 279, 900, (byte)3, (byte)18, (short)0, (short)0, (byte)10 },
                    { 278, 800, (byte)3, (byte)16, (short)0, (short)0, (byte)10 },
                    { 277, 700, (byte)3, (byte)14, (short)0, (short)0, (byte)10 },
                    { 276, 600, (byte)3, (byte)12, (short)0, (short)0, (byte)10 },
                    { 275, 500, (byte)3, (byte)10, (short)0, (short)0, (byte)10 },
                    { 274, 400, (byte)3, (byte)8, (short)0, (short)0, (byte)10 },
                    { 361, 1792, (byte)2, (byte)14, (short)0, (short)0, (byte)6 },
                    { 243, 1867, (byte)4, (byte)16, (short)0, (short)0, (byte)10 },
                    { 362, 2048, (byte)2, (byte)16, (short)0, (short)0, (byte)6 },
                    { 364, 2560, (byte)2, (byte)20, (short)0, (short)0, (byte)6 },
                    { 451, 1344, (byte)4, (byte)12, (short)0, (short)0, (byte)12 },
                    { 450, 1120, (byte)4, (byte)10, (short)0, (short)0, (byte)12 },
                    { 449, 896, (byte)4, (byte)8, (short)0, (short)0, (byte)12 },
                    { 448, 2333, (byte)4, (byte)20, (short)0, (short)0, (byte)10 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "BoardFeet", "Height", "Length", "OnHand", "Sold", "Width" },
                values: new object[,]
                {
                    { 447, 2100, (byte)4, (byte)18, (short)0, (short)0, (byte)10 },
                    { 446, 1867, (byte)4, (byte)16, (short)0, (short)0, (byte)10 },
                    { 445, 1633, (byte)4, (byte)14, (short)0, (short)0, (byte)10 },
                    { 444, 1400, (byte)4, (byte)12, (short)0, (short)0, (byte)10 },
                    { 443, 1167, (byte)4, (byte)10, (short)0, (short)0, (byte)10 },
                    { 442, 933, (byte)4, (byte)8, (short)0, (short)0, (byte)10 },
                    { 441, 2240, (byte)4, (byte)20, (short)0, (short)0, (byte)8 },
                    { 440, 2016, (byte)4, (byte)18, (short)0, (short)0, (byte)8 },
                    { 452, 1568, (byte)4, (byte)14, (short)0, (short)0, (byte)12 },
                    { 439, 1792, (byte)4, (byte)16, (short)0, (short)0, (byte)8 },
                    { 437, 1344, (byte)4, (byte)12, (short)0, (short)0, (byte)8 },
                    { 436, 1120, (byte)4, (byte)10, (short)0, (short)0, (byte)8 },
                    { 435, 896, (byte)4, (byte)8, (short)0, (short)0, (byte)8 },
                    { 434, 2240, (byte)4, (byte)20, (short)0, (short)0, (byte)6 },
                    { 433, 2016, (byte)4, (byte)18, (short)0, (short)0, (byte)6 },
                    { 432, 1792, (byte)4, (byte)16, (short)0, (short)0, (byte)6 },
                    { 431, 1568, (byte)4, (byte)14, (short)0, (short)0, (byte)6 },
                    { 430, 1344, (byte)4, (byte)12, (short)0, (short)0, (byte)6 },
                    { 429, 1120, (byte)4, (byte)10, (short)0, (short)0, (byte)6 },
                    { 428, 896, (byte)4, (byte)8, (short)0, (short)0, (byte)6 },
                    { 427, 2427, (byte)4, (byte)20, (short)0, (short)0, (byte)4 },
                    { 426, 2184, (byte)4, (byte)18, (short)0, (short)0, (byte)4 },
                    { 438, 1568, (byte)4, (byte)14, (short)0, (short)0, (byte)8 },
                    { 425, 1941, (byte)4, (byte)16, (short)0, (short)0, (byte)4 },
                    { 453, 1792, (byte)4, (byte)16, (short)0, (short)0, (byte)12 },
                    { 455, 2240, (byte)4, (byte)20, (short)0, (short)0, (byte)12 },
                    { 481, 1536, (byte)6, (byte)16, (short)0, (short)0, (byte)12 },
                    { 480, 1344, (byte)6, (byte)14, (short)0, (short)0, (byte)12 },
                    { 479, 1152, (byte)6, (byte)12, (short)0, (short)0, (byte)12 },
                    { 478, 960, (byte)6, (byte)10, (short)0, (short)0, (byte)12 },
                    { 477, 768, (byte)6, (byte)8, (short)0, (short)0, (byte)12 },
                    { 476, 2000, (byte)6, (byte)20, (short)0, (short)0, (byte)10 },
                    { 475, 1800, (byte)6, (byte)18, (short)0, (short)0, (byte)10 },
                    { 474, 1600, (byte)6, (byte)16, (short)0, (short)0, (byte)10 },
                    { 473, 1400, (byte)6, (byte)14, (short)0, (short)0, (byte)10 },
                    { 472, 1200, (byte)6, (byte)12, (short)0, (short)0, (byte)10 },
                    { 471, 1000, (byte)6, (byte)10, (short)0, (short)0, (byte)10 },
                    { 470, 800, (byte)6, (byte)8, (short)0, (short)0, (byte)10 },
                    { 454, 2016, (byte)4, (byte)18, (short)0, (short)0, (byte)12 },
                    { 469, 1920, (byte)6, (byte)20, (short)0, (short)0, (byte)8 },
                    { 467, 1536, (byte)6, (byte)16, (short)0, (short)0, (byte)8 },
                    { 466, 1344, (byte)6, (byte)14, (short)0, (short)0, (byte)8 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "BoardFeet", "Height", "Length", "OnHand", "Sold", "Width" },
                values: new object[,]
                {
                    { 465, 1152, (byte)6, (byte)12, (short)0, (short)0, (byte)8 },
                    { 464, 960, (byte)6, (byte)10, (short)0, (short)0, (byte)8 },
                    { 463, 768, (byte)6, (byte)8, (short)0, (short)0, (byte)8 },
                    { 462, 1920, (byte)6, (byte)20, (short)0, (short)0, (byte)6 },
                    { 461, 1728, (byte)6, (byte)18, (short)0, (short)0, (byte)6 },
                    { 460, 1536, (byte)6, (byte)16, (short)0, (short)0, (byte)6 },
                    { 459, 1344, (byte)6, (byte)14, (short)0, (short)0, (byte)6 },
                    { 458, 1152, (byte)6, (byte)12, (short)0, (short)0, (byte)6 },
                    { 457, 960, (byte)6, (byte)10, (short)0, (short)0, (byte)6 },
                    { 456, 768, (byte)6, (byte)8, (short)0, (short)0, (byte)6 },
                    { 468, 1728, (byte)6, (byte)18, (short)0, (short)0, (byte)8 },
                    { 424, 1699, (byte)4, (byte)14, (short)0, (short)0, (byte)4 },
                    { 423, 1456, (byte)4, (byte)12, (short)0, (short)0, (byte)4 },
                    { 422, 1213, (byte)4, (byte)10, (short)0, (short)0, (byte)4 },
                    { 390, 1872, (byte)3, (byte)16, (short)0, (short)0, (byte)4 },
                    { 389, 1638, (byte)3, (byte)14, (short)0, (short)0, (byte)4 },
                    { 388, 1404, (byte)3, (byte)12, (short)0, (short)0, (byte)4 },
                    { 387, 1170, (byte)3, (byte)10, (short)0, (short)0, (byte)4 },
                    { 386, 936, (byte)3, (byte)8, (short)0, (short)0, (byte)4 },
                    { 385, 2560, (byte)2, (byte)20, (short)0, (short)0, (byte)12 },
                    { 384, 2304, (byte)2, (byte)18, (short)0, (short)0, (byte)12 },
                    { 383, 2048, (byte)2, (byte)16, (short)0, (short)0, (byte)12 },
                    { 382, 1792, (byte)2, (byte)14, (short)0, (short)0, (byte)12 },
                    { 381, 1536, (byte)2, (byte)12, (short)0, (short)0, (byte)12 },
                    { 380, 1280, (byte)2, (byte)10, (short)0, (short)0, (byte)12 },
                    { 379, 1024, (byte)2, (byte)8, (short)0, (short)0, (byte)12 },
                    { 391, 2106, (byte)3, (byte)18, (short)0, (short)0, (byte)4 },
                    { 378, 2667, (byte)2, (byte)20, (short)0, (short)0, (byte)10 },
                    { 376, 2133, (byte)2, (byte)16, (short)0, (short)0, (byte)10 },
                    { 375, 1867, (byte)2, (byte)14, (short)0, (short)0, (byte)10 },
                    { 374, 1600, (byte)2, (byte)12, (short)0, (short)0, (byte)10 },
                    { 373, 1333, (byte)2, (byte)10, (short)0, (short)0, (byte)10 },
                    { 372, 1067, (byte)2, (byte)8, (short)0, (short)0, (byte)10 },
                    { 371, 2560, (byte)2, (byte)20, (short)0, (short)0, (byte)8 },
                    { 370, 2304, (byte)2, (byte)18, (short)0, (short)0, (byte)8 },
                    { 369, 2048, (byte)2, (byte)16, (short)0, (short)0, (byte)8 },
                    { 368, 1792, (byte)2, (byte)14, (short)0, (short)0, (byte)8 },
                    { 367, 1536, (byte)2, (byte)12, (short)0, (short)0, (byte)8 },
                    { 366, 1280, (byte)2, (byte)10, (short)0, (short)0, (byte)8 },
                    { 365, 1024, (byte)2, (byte)8, (short)0, (short)0, (byte)8 },
                    { 377, 2400, (byte)2, (byte)18, (short)0, (short)0, (byte)10 },
                    { 392, 2340, (byte)3, (byte)20, (short)0, (short)0, (byte)4 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "BoardFeet", "Height", "Length", "OnHand", "Sold", "Width" },
                values: new object[,]
                {
                    { 393, 864, (byte)3, (byte)8, (short)0, (short)0, (byte)6 },
                    { 394, 1080, (byte)3, (byte)10, (short)0, (short)0, (byte)6 },
                    { 421, 971, (byte)4, (byte)8, (short)0, (short)0, (byte)4 },
                    { 420, 2160, (byte)3, (byte)20, (short)0, (short)0, (byte)12 },
                    { 419, 1944, (byte)3, (byte)18, (short)0, (short)0, (byte)12 },
                    { 418, 1728, (byte)3, (byte)16, (short)0, (short)0, (byte)12 },
                    { 417, 1512, (byte)3, (byte)14, (short)0, (short)0, (byte)12 },
                    { 416, 1296, (byte)3, (byte)12, (short)0, (short)0, (byte)12 },
                    { 415, 1080, (byte)3, (byte)10, (short)0, (short)0, (byte)12 },
                    { 414, 864, (byte)3, (byte)8, (short)0, (short)0, (byte)12 },
                    { 413, 2250, (byte)3, (byte)20, (short)0, (short)0, (byte)10 },
                    { 412, 2025, (byte)3, (byte)18, (short)0, (short)0, (byte)10 },
                    { 411, 1800, (byte)3, (byte)16, (short)0, (short)0, (byte)10 },
                    { 410, 1575, (byte)3, (byte)14, (short)0, (short)0, (byte)10 },
                    { 409, 1350, (byte)3, (byte)12, (short)0, (short)0, (byte)10 },
                    { 408, 1125, (byte)3, (byte)10, (short)0, (short)0, (byte)10 },
                    { 407, 900, (byte)3, (byte)8, (short)0, (short)0, (byte)10 },
                    { 406, 2160, (byte)3, (byte)20, (short)0, (short)0, (byte)8 },
                    { 405, 1944, (byte)3, (byte)18, (short)0, (short)0, (byte)8 },
                    { 404, 1728, (byte)3, (byte)16, (short)0, (short)0, (byte)8 },
                    { 403, 1512, (byte)3, (byte)14, (short)0, (short)0, (byte)8 },
                    { 402, 1296, (byte)3, (byte)12, (short)0, (short)0, (byte)8 },
                    { 401, 1080, (byte)3, (byte)10, (short)0, (short)0, (byte)8 },
                    { 400, 864, (byte)3, (byte)8, (short)0, (short)0, (byte)8 },
                    { 399, 2160, (byte)3, (byte)20, (short)0, (short)0, (byte)6 },
                    { 398, 1944, (byte)3, (byte)18, (short)0, (short)0, (byte)6 },
                    { 397, 1728, (byte)3, (byte)16, (short)0, (short)0, (byte)6 },
                    { 396, 1512, (byte)3, (byte)14, (short)0, (short)0, (byte)6 },
                    { 395, 1296, (byte)3, (byte)12, (short)0, (short)0, (byte)6 },
                    { 363, 2304, (byte)2, (byte)18, (short)0, (short)0, (byte)6 },
                    { 482, 1728, (byte)6, (byte)18, (short)0, (short)0, (byte)12 },
                    { 242, 1633, (byte)4, (byte)14, (short)0, (short)0, (byte)10 },
                    { 240, 1167, (byte)4, (byte)10, (short)0, (short)0, (byte)10 },
                    { 88, 1568, (byte)4, (byte)14, (short)0, (short)0, (byte)8 },
                    { 87, 1344, (byte)4, (byte)12, (short)0, (short)0, (byte)8 },
                    { 86, 1120, (byte)4, (byte)10, (short)0, (short)0, (byte)8 },
                    { 85, 896, (byte)4, (byte)8, (short)0, (short)0, (byte)8 },
                    { 84, 2240, (byte)4, (byte)20, (short)0, (short)0, (byte)6 },
                    { 83, 2016, (byte)4, (byte)18, (short)0, (short)0, (byte)6 },
                    { 82, 1792, (byte)4, (byte)16, (short)0, (short)0, (byte)6 },
                    { 81, 1568, (byte)4, (byte)14, (short)0, (short)0, (byte)6 },
                    { 80, 1344, (byte)4, (byte)12, (short)0, (short)0, (byte)6 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "BoardFeet", "Height", "Length", "OnHand", "Sold", "Width" },
                values: new object[,]
                {
                    { 79, 1120, (byte)4, (byte)10, (short)0, (short)0, (byte)6 },
                    { 78, 896, (byte)4, (byte)8, (short)0, (short)0, (byte)6 },
                    { 77, 2427, (byte)4, (byte)20, (short)0, (short)0, (byte)4 },
                    { 89, 1792, (byte)4, (byte)16, (short)0, (short)0, (byte)8 },
                    { 76, 2148, (byte)4, (byte)18, (short)0, (short)0, (byte)4 },
                    { 74, 1699, (byte)4, (byte)14, (short)0, (short)0, (byte)4 },
                    { 73, 1456, (byte)4, (byte)12, (short)0, (short)0, (byte)4 },
                    { 72, 1213, (byte)4, (byte)10, (short)0, (short)0, (byte)4 },
                    { 71, 971, (byte)4, (byte)8, (short)0, (short)0, (byte)4 },
                    { 70, 2160, (byte)3, (byte)20, (short)0, (short)0, (byte)12 },
                    { 69, 1944, (byte)3, (byte)18, (short)0, (short)0, (byte)12 },
                    { 68, 1728, (byte)3, (byte)16, (short)0, (short)0, (byte)12 },
                    { 67, 1512, (byte)3, (byte)14, (short)0, (short)0, (byte)12 },
                    { 66, 1296, (byte)3, (byte)12, (short)0, (short)0, (byte)12 },
                    { 65, 1080, (byte)3, (byte)10, (short)0, (short)0, (byte)12 },
                    { 64, 864, (byte)3, (byte)8, (short)0, (short)0, (byte)12 },
                    { 63, 2250, (byte)3, (byte)20, (short)0, (short)0, (byte)10 },
                    { 75, 1941, (byte)4, (byte)16, (short)0, (short)0, (byte)4 },
                    { 62, 2025, (byte)3, (byte)18, (short)0, (short)0, (byte)10 },
                    { 90, 2016, (byte)4, (byte)18, (short)0, (short)0, (byte)8 },
                    { 92, 933, (byte)4, (byte)8, (short)0, (short)0, (byte)10 },
                    { 118, 1728, (byte)6, (byte)18, (short)0, (short)0, (byte)8 },
                    { 117, 1536, (byte)6, (byte)16, (short)0, (short)0, (byte)8 },
                    { 116, 1344, (byte)6, (byte)14, (short)0, (short)0, (byte)8 },
                    { 115, 1152, (byte)6, (byte)12, (short)0, (short)0, (byte)8 },
                    { 114, 960, (byte)6, (byte)10, (short)0, (short)0, (byte)8 },
                    { 113, 768, (byte)6, (byte)8, (short)0, (short)0, (byte)8 },
                    { 112, 1920, (byte)6, (byte)20, (short)0, (short)0, (byte)6 },
                    { 111, 1728, (byte)6, (byte)18, (short)0, (short)0, (byte)6 },
                    { 110, 1536, (byte)6, (byte)16, (short)0, (short)0, (byte)6 },
                    { 109, 1344, (byte)6, (byte)14, (short)0, (short)0, (byte)6 },
                    { 108, 1152, (byte)6, (byte)12, (short)0, (short)0, (byte)6 },
                    { 107, 960, (byte)6, (byte)10, (short)0, (short)0, (byte)6 },
                    { 91, 2240, (byte)4, (byte)20, (short)0, (short)0, (byte)8 },
                    { 106, 768, (byte)6, (byte)8, (short)0, (short)0, (byte)6 },
                    { 104, 2016, (byte)4, (byte)18, (short)0, (short)0, (byte)12 },
                    { 103, 1792, (byte)4, (byte)16, (short)0, (short)0, (byte)12 },
                    { 102, 1568, (byte)4, (byte)14, (short)0, (short)0, (byte)12 },
                    { 101, 1344, (byte)4, (byte)12, (short)0, (short)0, (byte)12 },
                    { 100, 1120, (byte)4, (byte)10, (short)0, (short)0, (byte)12 },
                    { 99, 896, (byte)4, (byte)8, (short)0, (short)0, (byte)12 },
                    { 98, 2333, (byte)4, (byte)20, (short)0, (short)0, (byte)10 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "BoardFeet", "Height", "Length", "OnHand", "Sold", "Width" },
                values: new object[,]
                {
                    { 97, 2100, (byte)4, (byte)18, (short)0, (short)0, (byte)10 },
                    { 96, 1867, (byte)4, (byte)16, (short)0, (short)0, (byte)10 },
                    { 95, 1633, (byte)4, (byte)14, (short)0, (short)0, (byte)10 },
                    { 94, 1400, (byte)4, (byte)12, (short)0, (short)0, (byte)10 },
                    { 93, 1167, (byte)4, (byte)10, (short)0, (short)0, (byte)10 },
                    { 105, 2240, (byte)4, (byte)20, (short)0, (short)0, (byte)12 },
                    { 61, 1800, (byte)3, (byte)16, (short)0, (short)0, (byte)10 },
                    { 60, 1575, (byte)3, (byte)14, (short)0, (short)0, (byte)10 },
                    { 59, 1350, (byte)3, (byte)12, (short)0, (short)0, (byte)10 },
                    { 27, 2400, (byte)2, (byte)18, (short)0, (short)0, (byte)10 },
                    { 26, 2133, (byte)2, (byte)16, (short)0, (short)0, (byte)10 },
                    { 25, 1867, (byte)2, (byte)14, (short)0, (short)0, (byte)10 },
                    { 24, 1600, (byte)2, (byte)12, (short)0, (short)0, (byte)10 },
                    { 23, 1333, (byte)2, (byte)10, (short)0, (short)0, (byte)10 },
                    { 22, 1067, (byte)2, (byte)8, (short)0, (short)0, (byte)10 },
                    { 21, 2560, (byte)2, (byte)20, (short)0, (short)0, (byte)8 },
                    { 20, 2304, (byte)2, (byte)18, (short)0, (short)0, (byte)8 },
                    { 19, 2048, (byte)2, (byte)16, (short)0, (short)0, (byte)8 },
                    { 18, 1792, (byte)2, (byte)14, (short)0, (short)0, (byte)8 },
                    { 17, 1536, (byte)2, (byte)12, (short)0, (short)0, (byte)8 },
                    { 16, 1280, (byte)2, (byte)10, (short)0, (short)0, (byte)8 },
                    { 28, 2667, (byte)2, (byte)20, (short)0, (short)0, (byte)10 },
                    { 15, 1024, (byte)2, (byte)8, (short)0, (short)0, (byte)8 },
                    { 13, 2304, (byte)2, (byte)18, (short)0, (short)0, (byte)6 },
                    { 12, 2048, (byte)2, (byte)16, (short)0, (short)0, (byte)6 },
                    { 11, 1792, (byte)2, (byte)14, (short)0, (short)0, (byte)6 },
                    { 10, 1536, (byte)2, (byte)12, (short)0, (short)0, (byte)6 },
                    { 9, 1280, (byte)2, (byte)10, (short)0, (short)0, (byte)6 },
                    { 8, 1024, (byte)2, (byte)8, (short)0, (short)0, (byte)6 },
                    { 7, 2773, (byte)2, (byte)20, (short)0, (short)0, (byte)4 },
                    { 6, 2496, (byte)2, (byte)18, (short)0, (short)0, (byte)4 },
                    { 5, 2219, (byte)2, (byte)16, (short)0, (short)0, (byte)4 },
                    { 4, 1941, (byte)2, (byte)14, (short)0, (short)0, (byte)4 },
                    { 3, 1664, (byte)2, (byte)12, (short)0, (short)0, (byte)4 },
                    { 2, 1387, (byte)2, (byte)10, (short)0, (short)0, (byte)4 },
                    { 14, 2560, (byte)2, (byte)20, (short)0, (short)0, (byte)6 },
                    { 29, 1024, (byte)2, (byte)8, (short)0, (short)0, (byte)12 },
                    { 30, 1280, (byte)2, (byte)10, (short)0, (short)0, (byte)12 },
                    { 31, 1536, (byte)2, (byte)12, (short)0, (short)0, (byte)12 },
                    { 58, 1125, (byte)3, (byte)10, (short)0, (short)0, (byte)10 },
                    { 57, 900, (byte)3, (byte)8, (short)0, (short)0, (byte)10 },
                    { 56, 2160, (byte)3, (byte)20, (short)0, (short)0, (byte)8 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "BoardFeet", "Height", "Length", "OnHand", "Sold", "Width" },
                values: new object[,]
                {
                    { 55, 1944, (byte)3, (byte)18, (short)0, (short)0, (byte)8 },
                    { 54, 1728, (byte)3, (byte)16, (short)0, (short)0, (byte)8 },
                    { 53, 1512, (byte)3, (byte)14, (short)0, (short)0, (byte)8 },
                    { 52, 1296, (byte)3, (byte)12, (short)0, (short)0, (byte)8 },
                    { 51, 1080, (byte)3, (byte)10, (short)0, (short)0, (byte)8 },
                    { 50, 864, (byte)3, (byte)8, (short)0, (short)0, (byte)8 },
                    { 49, 2160, (byte)3, (byte)20, (short)0, (short)0, (byte)6 },
                    { 48, 1944, (byte)3, (byte)18, (short)0, (short)0, (byte)6 },
                    { 47, 1728, (byte)3, (byte)16, (short)0, (short)0, (byte)6 },
                    { 46, 1512, (byte)3, (byte)14, (short)0, (short)0, (byte)6 },
                    { 45, 1296, (byte)3, (byte)12, (short)0, (short)0, (byte)6 },
                    { 44, 1080, (byte)3, (byte)10, (short)0, (short)0, (byte)6 },
                    { 43, 864, (byte)3, (byte)8, (short)0, (short)0, (byte)6 },
                    { 42, 2340, (byte)3, (byte)20, (short)0, (short)0, (byte)4 },
                    { 41, 2106, (byte)3, (byte)18, (short)0, (short)0, (byte)4 },
                    { 40, 1872, (byte)3, (byte)16, (short)0, (short)0, (byte)4 },
                    { 39, 1638, (byte)3, (byte)14, (short)0, (short)0, (byte)4 },
                    { 38, 1404, (byte)3, (byte)12, (short)0, (short)0, (byte)4 },
                    { 37, 1170, (byte)3, (byte)10, (short)0, (short)0, (byte)4 },
                    { 36, 936, (byte)3, (byte)8, (short)0, (short)0, (byte)4 },
                    { 35, 2560, (byte)2, (byte)20, (short)0, (short)0, (byte)12 },
                    { 34, 2304, (byte)2, (byte)18, (short)0, (short)0, (byte)12 },
                    { 33, 2048, (byte)2, (byte)16, (short)0, (short)0, (byte)12 },
                    { 32, 1792, (byte)2, (byte)14, (short)0, (short)0, (byte)12 },
                    { 119, 1920, (byte)6, (byte)20, (short)0, (short)0, (byte)8 },
                    { 241, 1400, (byte)4, (byte)12, (short)0, (short)0, (byte)10 },
                    { 120, 800, (byte)6, (byte)8, (short)0, (short)0, (byte)10 },
                    { 122, 1200, (byte)6, (byte)12, (short)0, (short)0, (byte)10 },
                    { 209, 1200, (byte)4, (byte)18, (short)0, (short)0, (byte)10 },
                    { 208, 1067, (byte)4, (byte)16, (short)0, (short)0, (byte)10 },
                    { 207, 934, (byte)4, (byte)14, (short)0, (short)0, (byte)10 },
                    { 206, 800, (byte)4, (byte)12, (short)0, (short)0, (byte)10 },
                    { 205, 667, (byte)4, (byte)10, (short)0, (short)0, (byte)10 },
                    { 204, 534, (byte)4, (byte)8, (short)0, (short)0, (byte)10 },
                    { 203, 1280, (byte)4, (byte)20, (short)0, (short)0, (byte)8 },
                    { 202, 1152, (byte)4, (byte)18, (short)0, (short)0, (byte)8 },
                    { 201, 1024, (byte)4, (byte)16, (short)0, (short)0, (byte)8 },
                    { 200, 896, (byte)4, (byte)14, (short)0, (short)0, (byte)8 },
                    { 199, 768, (byte)4, (byte)12, (short)0, (short)0, (byte)8 },
                    { 198, 640, (byte)4, (byte)10, (short)0, (short)0, (byte)8 },
                    { 210, 1334, (byte)4, (byte)20, (short)0, (short)0, (byte)10 },
                    { 197, 512, (byte)4, (byte)8, (short)0, (short)0, (byte)8 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "BoardFeet", "Height", "Length", "OnHand", "Sold", "Width" },
                values: new object[,]
                {
                    { 195, 2016, (byte)4, (byte)18, (short)0, (short)0, (byte)6 },
                    { 194, 1792, (byte)4, (byte)16, (short)0, (short)0, (byte)6 },
                    { 193, 1568, (byte)4, (byte)14, (short)0, (short)0, (byte)6 },
                    { 192, 1344, (byte)4, (byte)12, (short)0, (short)0, (byte)6 },
                    { 191, 1120, (byte)4, (byte)10, (short)0, (short)0, (byte)6 },
                    { 190, 896, (byte)4, (byte)8, (short)0, (short)0, (byte)6 },
                    { 189, 2427, (byte)4, (byte)20, (short)0, (short)0, (byte)4 },
                    { 188, 2184, (byte)4, (byte)18, (short)0, (short)0, (byte)4 },
                    { 187, 1941, (byte)4, (byte)16, (short)0, (short)0, (byte)4 },
                    { 186, 1699, (byte)4, (byte)14, (short)0, (short)0, (byte)4 },
                    { 185, 1456, (byte)4, (byte)12, (short)0, (short)0, (byte)4 },
                    { 184, 1213, (byte)4, (byte)10, (short)0, (short)0, (byte)4 },
                    { 196, 2240, (byte)4, (byte)20, (short)0, (short)0, (byte)6 },
                    { 183, 971, (byte)4, (byte)8, (short)0, (short)0, (byte)4 },
                    { 211, 512, (byte)4, (byte)8, (short)0, (short)0, (byte)12 },
                    { 213, 768, (byte)4, (byte)12, (short)0, (short)0, (byte)12 },
                    { 239, 933, (byte)4, (byte)8, (short)0, (short)0, (byte)10 },
                    { 238, 2240, (byte)4, (byte)20, (short)0, (short)0, (byte)8 },
                    { 237, 2016, (byte)4, (byte)18, (short)0, (short)0, (byte)8 },
                    { 236, 1792, (byte)4, (byte)16, (short)0, (short)0, (byte)8 },
                    { 235, 1568, (byte)4, (byte)14, (short)0, (short)0, (byte)8 },
                    { 234, 1344, (byte)4, (byte)12, (short)0, (short)0, (byte)8 },
                    { 233, 1120, (byte)4, (byte)10, (short)0, (short)0, (byte)8 },
                    { 232, 896, (byte)4, (byte)8, (short)0, (short)0, (byte)8 },
                    { 231, 2240, (byte)4, (byte)20, (short)0, (short)0, (byte)6 },
                    { 230, 2016, (byte)4, (byte)18, (short)0, (short)0, (byte)6 },
                    { 229, 1792, (byte)4, (byte)16, (short)0, (short)0, (byte)6 },
                    { 228, 1568, (byte)4, (byte)14, (short)0, (short)0, (byte)6 },
                    { 212, 640, (byte)4, (byte)10, (short)0, (short)0, (byte)12 },
                    { 227, 1344, (byte)4, (byte)12, (short)0, (short)0, (byte)6 },
                    { 225, 896, (byte)4, (byte)8, (short)0, (short)0, (byte)6 },
                    { 224, 2427, (byte)4, (byte)20, (short)0, (short)0, (byte)4 },
                    { 223, 2184, (byte)4, (byte)18, (short)0, (short)0, (byte)4 },
                    { 222, 1941, (byte)4, (byte)16, (short)0, (short)0, (byte)4 },
                    { 221, 1699, (byte)4, (byte)14, (short)0, (short)0, (byte)4 },
                    { 220, 1456, (byte)4, (byte)12, (short)0, (short)0, (byte)4 },
                    { 219, 1213, (byte)4, (byte)10, (short)0, (short)0, (byte)4 },
                    { 218, 971, (byte)4, (byte)8, (short)0, (short)0, (byte)4 },
                    { 217, 1280, (byte)4, (byte)20, (short)0, (short)0, (byte)12 },
                    { 216, 1152, (byte)4, (byte)18, (short)0, (short)0, (byte)12 },
                    { 215, 1024, (byte)4, (byte)16, (short)0, (short)0, (byte)12 },
                    { 214, 896, (byte)4, (byte)14, (short)0, (short)0, (byte)12 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "BoardFeet", "Height", "Length", "OnHand", "Sold", "Width" },
                values: new object[,]
                {
                    { 226, 1120, (byte)4, (byte)10, (short)0, (short)0, (byte)6 },
                    { 182, 1280, (byte)2, (byte)20, (short)0, (short)0, (byte)12 },
                    { 181, 1152, (byte)2, (byte)18, (short)0, (short)0, (byte)12 },
                    { 180, 1024, (byte)2, (byte)16, (short)0, (short)0, (byte)12 },
                    { 148, 1109, (byte)2, (byte)8, (short)0, (short)0, (byte)4 },
                    { 147, 2560, (byte)2, (byte)20, (short)0, (short)0, (byte)6 },
                    { 146, 2304, (byte)2, (byte)18, (short)0, (short)0, (byte)6 },
                    { 145, 2048, (byte)2, (byte)16, (short)0, (short)0, (byte)6 },
                    { 144, 1792, (byte)2, (byte)14, (short)0, (short)0, (byte)6 },
                    { 143, 1536, (byte)2, (byte)12, (short)0, (short)0, (byte)6 },
                    { 142, 1280, (byte)2, (byte)10, (short)0, (short)0, (byte)6 },
                    { 141, 1024, (byte)2, (byte)8, (short)0, (short)0, (byte)6 },
                    { 140, 2773, (byte)2, (byte)20, (short)0, (short)0, (byte)4 },
                    { 139, 2496, (byte)2, (byte)18, (short)0, (short)0, (byte)4 },
                    { 138, 2219, (byte)2, (byte)16, (short)0, (short)0, (byte)4 },
                    { 137, 1941, (byte)2, (byte)14, (short)0, (short)0, (byte)4 },
                    { 149, 1387, (byte)2, (byte)10, (short)0, (short)0, (byte)4 },
                    { 136, 1664, (byte)2, (byte)12, (short)0, (short)0, (byte)4 },
                    { 134, 1109, (byte)2, (byte)8, (short)0, (short)0, (byte)4 },
                    { 133, 1920, (byte)6, (byte)20, (short)0, (short)0, (byte)12 },
                    { 132, 1728, (byte)6, (byte)18, (short)0, (short)0, (byte)12 },
                    { 131, 1536, (byte)6, (byte)16, (short)0, (short)0, (byte)12 },
                    { 130, 1344, (byte)6, (byte)14, (short)0, (short)0, (byte)12 },
                    { 129, 1152, (byte)6, (byte)12, (short)0, (short)0, (byte)12 },
                    { 128, 960, (byte)6, (byte)10, (short)0, (short)0, (byte)12 },
                    { 127, 768, (byte)6, (byte)8, (short)0, (short)0, (byte)12 },
                    { 126, 2000, (byte)6, (byte)20, (short)0, (short)0, (byte)10 },
                    { 125, 1800, (byte)6, (byte)18, (short)0, (short)0, (byte)10 },
                    { 124, 1600, (byte)6, (byte)16, (short)0, (short)0, (byte)10 },
                    { 123, 1400, (byte)6, (byte)14, (short)0, (short)0, (byte)10 },
                    { 135, 1387, (byte)2, (byte)10, (short)0, (short)0, (byte)4 },
                    { 150, 1664, (byte)2, (byte)12, (short)0, (short)0, (byte)4 },
                    { 151, 1941, (byte)2, (byte)14, (short)0, (short)0, (byte)4 },
                    { 152, 2219, (byte)2, (byte)16, (short)0, (short)0, (byte)4 },
                    { 179, 896, (byte)2, (byte)14, (short)0, (short)0, (byte)12 },
                    { 178, 768, (byte)2, (byte)12, (short)0, (short)0, (byte)12 },
                    { 177, 640, (byte)2, (byte)10, (short)0, (short)0, (byte)12 },
                    { 176, 512, (byte)2, (byte)8, (short)0, (short)0, (byte)12 },
                    { 175, 1334, (byte)2, (byte)20, (short)0, (short)0, (byte)10 },
                    { 174, 1200, (byte)2, (byte)18, (short)0, (short)0, (byte)10 },
                    { 173, 1067, (byte)2, (byte)16, (short)0, (short)0, (byte)10 },
                    { 172, 934, (byte)2, (byte)14, (short)0, (short)0, (byte)10 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "BoardFeet", "Height", "Length", "OnHand", "Sold", "Width" },
                values: new object[,]
                {
                    { 171, 800, (byte)2, (byte)12, (short)0, (short)0, (byte)10 },
                    { 170, 667, (byte)2, (byte)10, (short)0, (short)0, (byte)10 },
                    { 169, 533, (byte)2, (byte)8, (short)0, (short)0, (byte)10 },
                    { 168, 1280, (byte)2, (byte)20, (short)0, (short)0, (byte)8 },
                    { 167, 1152, (byte)2, (byte)18, (short)0, (short)0, (byte)8 },
                    { 166, 1024, (byte)2, (byte)16, (short)0, (short)0, (byte)8 },
                    { 165, 896, (byte)2, (byte)14, (short)0, (short)0, (byte)8 },
                    { 164, 768, (byte)2, (byte)12, (short)0, (short)0, (byte)8 },
                    { 163, 640, (byte)2, (byte)10, (short)0, (short)0, (byte)8 },
                    { 162, 512, (byte)2, (byte)8, (short)0, (short)0, (byte)8 },
                    { 161, 2560, (byte)2, (byte)20, (short)0, (short)0, (byte)6 },
                    { 160, 2304, (byte)2, (byte)18, (short)0, (short)0, (byte)6 },
                    { 159, 2048, (byte)2, (byte)16, (short)0, (short)0, (byte)6 },
                    { 158, 1792, (byte)2, (byte)14, (short)0, (short)0, (byte)6 },
                    { 157, 1536, (byte)2, (byte)12, (short)0, (short)0, (byte)6 },
                    { 156, 1280, (byte)2, (byte)10, (short)0, (short)0, (byte)6 },
                    { 155, 1024, (byte)2, (byte)8, (short)0, (short)0, (byte)6 },
                    { 154, 2773, (byte)2, (byte)20, (short)0, (short)0, (byte)4 },
                    { 153, 2496, (byte)2, (byte)18, (short)0, (short)0, (byte)4 },
                    { 121, 1000, (byte)6, (byte)10, (short)0, (short)0, (byte)10 },
                    { 483, 1920, (byte)6, (byte)20, (short)0, (short)0, (byte)12 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 319 },
                    { 5, 319 },
                    { 4, 320 },
                    { 5, 320 },
                    { 4, 321 },
                    { 5, 321 },
                    { 4, 322 },
                    { 5, 322 },
                    { 4, 323 },
                    { 5, 323 },
                    { 4, 324 },
                    { 5, 324 },
                    { 5, 318 },
                    { 4, 325 },
                    { 4, 326 },
                    { 5, 326 },
                    { 4, 327 },
                    { 5, 327 },
                    { 4, 328 },
                    { 5, 328 },
                    { 4, 329 },
                    { 5, 329 },
                    { 4, 330 },
                    { 5, 330 },
                    { 4, 331 },
                    { 5, 331 },
                    { 5, 325 },
                    { 4, 332 },
                    { 4, 318 },
                    { 4, 317 },
                    { 4, 304 },
                    { 5, 304 },
                    { 4, 305 },
                    { 5, 305 },
                    { 4, 306 },
                    { 5, 306 },
                    { 4, 307 },
                    { 5, 307 },
                    { 4, 308 },
                    { 5, 308 },
                    { 4, 309 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 5, 309 },
                    { 5, 317 },
                    { 4, 310 },
                    { 4, 311 },
                    { 5, 311 },
                    { 4, 312 },
                    { 5, 312 },
                    { 4, 313 },
                    { 5, 313 },
                    { 4, 314 },
                    { 5, 314 },
                    { 4, 315 },
                    { 5, 315 },
                    { 4, 316 },
                    { 5, 316 },
                    { 5, 310 },
                    { 5, 303 },
                    { 5, 332 },
                    { 5, 333 },
                    { 4, 349 },
                    { 5, 349 },
                    { 4, 350 },
                    { 5, 350 },
                    { 4, 351 },
                    { 6, 351 },
                    { 4, 352 },
                    { 6, 352 },
                    { 4, 353 },
                    { 6, 353 },
                    { 4, 354 },
                    { 6, 354 },
                    { 5, 348 },
                    { 4, 355 },
                    { 4, 356 },
                    { 6, 356 },
                    { 4, 357 },
                    { 6, 357 },
                    { 4, 358 },
                    { 6, 358 },
                    { 4, 359 },
                    { 6, 359 },
                    { 4, 360 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 6, 360 },
                    { 4, 361 },
                    { 6, 361 },
                    { 6, 355 },
                    { 4, 333 },
                    { 4, 348 },
                    { 4, 347 },
                    { 4, 334 },
                    { 5, 334 },
                    { 4, 335 },
                    { 5, 335 },
                    { 4, 336 },
                    { 5, 336 },
                    { 4, 337 },
                    { 5, 337 },
                    { 4, 338 },
                    { 5, 338 },
                    { 4, 339 },
                    { 5, 339 },
                    { 5, 347 },
                    { 4, 340 },
                    { 4, 341 },
                    { 5, 341 },
                    { 4, 342 },
                    { 5, 342 },
                    { 4, 343 },
                    { 5, 343 },
                    { 4, 344 },
                    { 5, 344 },
                    { 4, 345 },
                    { 5, 345 },
                    { 4, 346 },
                    { 5, 346 },
                    { 5, 340 },
                    { 4, 303 },
                    { 5, 302 },
                    { 4, 302 },
                    { 5, 258 },
                    { 3, 259 },
                    { 5, 259 },
                    { 3, 260 },
                    { 5, 260 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 3, 261 },
                    { 5, 261 },
                    { 3, 262 },
                    { 5, 262 },
                    { 3, 263 },
                    { 5, 263 },
                    { 3, 264 },
                    { 3, 258 },
                    { 5, 264 },
                    { 5, 265 },
                    { 3, 266 },
                    { 5, 266 },
                    { 3, 267 },
                    { 5, 267 },
                    { 3, 268 },
                    { 5, 268 },
                    { 3, 269 },
                    { 5, 269 },
                    { 3, 270 },
                    { 5, 270 },
                    { 3, 271 },
                    { 3, 265 },
                    { 5, 271 },
                    { 5, 257 },
                    { 5, 256 },
                    { 5, 243 },
                    { 4, 244 },
                    { 5, 244 },
                    { 4, 245 },
                    { 5, 245 },
                    { 4, 246 },
                    { 5, 246 },
                    { 4, 247 },
                    { 5, 247 },
                    { 4, 248 },
                    { 5, 248 },
                    { 4, 249 },
                    { 3, 257 },
                    { 5, 249 },
                    { 5, 250 },
                    { 4, 251 },
                    { 5, 251 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 4, 252 },
                    { 5, 252 },
                    { 3, 253 },
                    { 5, 253 },
                    { 3, 254 },
                    { 5, 254 },
                    { 3, 255 },
                    { 5, 255 },
                    { 3, 256 },
                    { 4, 250 },
                    { 3, 272 },
                    { 5, 272 },
                    { 3, 273 },
                    { 4, 289 },
                    { 5, 289 },
                    { 4, 290 },
                    { 5, 290 },
                    { 4, 291 },
                    { 5, 291 },
                    { 4, 292 },
                    { 5, 292 },
                    { 4, 293 },
                    { 5, 293 },
                    { 4, 294 },
                    { 5, 294 },
                    { 5, 288 },
                    { 4, 295 },
                    { 4, 296 },
                    { 5, 296 },
                    { 4, 297 },
                    { 5, 297 },
                    { 4, 298 },
                    { 5, 298 },
                    { 4, 299 },
                    { 5, 299 },
                    { 4, 300 },
                    { 5, 300 },
                    { 4, 301 },
                    { 5, 301 },
                    { 5, 295 },
                    { 4, 288 },
                    { 5, 287 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 3, 287 },
                    { 5, 273 },
                    { 3, 274 },
                    { 5, 274 },
                    { 3, 275 },
                    { 5, 275 },
                    { 3, 276 },
                    { 5, 276 },
                    { 3, 277 },
                    { 5, 277 },
                    { 3, 278 },
                    { 5, 278 },
                    { 3, 279 },
                    { 5, 279 },
                    { 3, 280 },
                    { 5, 280 },
                    { 3, 281 },
                    { 5, 281 },
                    { 3, 282 },
                    { 5, 282 },
                    { 3, 283 },
                    { 5, 283 },
                    { 3, 284 },
                    { 5, 284 },
                    { 3, 285 },
                    { 5, 285 },
                    { 3, 286 },
                    { 5, 286 },
                    { 4, 362 },
                    { 6, 362 },
                    { 4, 363 },
                    { 6, 363 },
                    { 6, 439 },
                    { 4, 440 },
                    { 6, 440 },
                    { 4, 441 },
                    { 6, 441 },
                    { 4, 442 },
                    { 6, 442 },
                    { 4, 443 },
                    { 6, 443 },
                    { 4, 444 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 6, 444 },
                    { 4, 445 },
                    { 4, 439 },
                    { 6, 445 },
                    { 6, 446 },
                    { 4, 447 },
                    { 6, 447 },
                    { 4, 448 },
                    { 6, 448 },
                    { 4, 449 },
                    { 6, 449 },
                    { 4, 450 },
                    { 6, 450 },
                    { 4, 451 },
                    { 6, 451 },
                    { 4, 452 },
                    { 4, 446 },
                    { 6, 452 },
                    { 6, 438 },
                    { 6, 437 },
                    { 6, 424 },
                    { 4, 425 },
                    { 6, 425 },
                    { 4, 426 },
                    { 6, 426 },
                    { 4, 427 },
                    { 6, 427 },
                    { 4, 428 },
                    { 6, 428 },
                    { 4, 429 },
                    { 6, 429 },
                    { 4, 430 },
                    { 4, 438 },
                    { 6, 430 },
                    { 6, 431 },
                    { 4, 432 },
                    { 6, 432 },
                    { 4, 433 },
                    { 6, 433 },
                    { 4, 434 },
                    { 6, 434 },
                    { 4, 435 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 6, 435 },
                    { 4, 436 },
                    { 6, 436 },
                    { 4, 437 },
                    { 4, 431 },
                    { 4, 453 },
                    { 6, 453 },
                    { 4, 454 },
                    { 4, 470 },
                    { 6, 470 },
                    { 4, 471 },
                    { 6, 471 },
                    { 4, 472 },
                    { 6, 472 },
                    { 4, 473 },
                    { 6, 473 },
                    { 4, 474 },
                    { 6, 474 },
                    { 4, 475 },
                    { 6, 475 },
                    { 6, 469 },
                    { 4, 476 },
                    { 4, 477 },
                    { 6, 477 },
                    { 4, 478 },
                    { 6, 478 },
                    { 4, 479 },
                    { 6, 479 },
                    { 4, 480 },
                    { 6, 480 },
                    { 4, 481 },
                    { 6, 481 },
                    { 4, 482 },
                    { 6, 482 },
                    { 6, 476 },
                    { 4, 469 },
                    { 6, 468 },
                    { 4, 468 },
                    { 6, 454 },
                    { 4, 455 },
                    { 6, 455 },
                    { 4, 456 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 6, 456 },
                    { 4, 457 },
                    { 6, 457 },
                    { 4, 458 },
                    { 6, 458 },
                    { 4, 459 },
                    { 6, 459 },
                    { 4, 460 },
                    { 6, 460 },
                    { 4, 461 },
                    { 6, 461 },
                    { 4, 462 },
                    { 6, 462 },
                    { 4, 463 },
                    { 6, 463 },
                    { 4, 464 },
                    { 6, 464 },
                    { 4, 465 },
                    { 6, 465 },
                    { 4, 466 },
                    { 6, 466 },
                    { 4, 467 },
                    { 6, 467 },
                    { 4, 424 },
                    { 4, 243 },
                    { 6, 423 },
                    { 6, 422 },
                    { 4, 379 },
                    { 6, 379 },
                    { 4, 380 },
                    { 6, 380 },
                    { 4, 381 },
                    { 6, 381 },
                    { 4, 382 },
                    { 6, 382 },
                    { 4, 383 },
                    { 6, 383 },
                    { 4, 384 },
                    { 6, 384 },
                    { 6, 378 },
                    { 4, 385 },
                    { 4, 386 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 6, 386 },
                    { 4, 387 },
                    { 6, 387 },
                    { 4, 388 },
                    { 6, 388 },
                    { 4, 389 },
                    { 6, 389 },
                    { 4, 390 },
                    { 6, 390 },
                    { 4, 391 },
                    { 6, 391 },
                    { 6, 385 },
                    { 4, 392 },
                    { 4, 378 },
                    { 4, 377 },
                    { 4, 364 },
                    { 6, 364 },
                    { 4, 365 },
                    { 6, 365 },
                    { 4, 366 },
                    { 6, 366 },
                    { 4, 367 },
                    { 6, 367 },
                    { 4, 368 },
                    { 6, 368 },
                    { 4, 369 },
                    { 6, 369 },
                    { 6, 377 },
                    { 4, 370 },
                    { 4, 371 },
                    { 6, 371 },
                    { 4, 372 },
                    { 6, 372 },
                    { 4, 373 },
                    { 6, 373 },
                    { 4, 374 },
                    { 6, 374 },
                    { 4, 375 },
                    { 6, 375 },
                    { 4, 376 },
                    { 6, 376 },
                    { 6, 370 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 6, 392 },
                    { 4, 393 },
                    { 6, 393 },
                    { 6, 409 },
                    { 4, 410 },
                    { 6, 410 },
                    { 4, 411 },
                    { 6, 411 },
                    { 4, 412 },
                    { 6, 412 },
                    { 4, 413 },
                    { 6, 413 },
                    { 4, 414 },
                    { 6, 414 },
                    { 4, 415 },
                    { 4, 409 },
                    { 6, 415 },
                    { 6, 416 },
                    { 4, 417 },
                    { 6, 417 },
                    { 4, 418 },
                    { 6, 418 },
                    { 4, 419 },
                    { 6, 419 },
                    { 4, 420 },
                    { 6, 420 },
                    { 4, 421 },
                    { 6, 421 },
                    { 4, 422 },
                    { 4, 416 },
                    { 6, 408 },
                    { 4, 408 },
                    { 6, 407 },
                    { 4, 394 },
                    { 6, 394 },
                    { 4, 395 },
                    { 6, 395 },
                    { 4, 396 },
                    { 6, 396 },
                    { 4, 397 },
                    { 6, 397 },
                    { 4, 398 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 6, 398 },
                    { 4, 399 },
                    { 6, 399 },
                    { 4, 400 },
                    { 6, 400 },
                    { 4, 401 },
                    { 6, 401 },
                    { 4, 402 },
                    { 6, 402 },
                    { 4, 403 },
                    { 6, 403 },
                    { 4, 404 },
                    { 6, 404 },
                    { 4, 405 },
                    { 6, 405 },
                    { 4, 406 },
                    { 6, 406 },
                    { 4, 407 },
                    { 4, 423 },
                    { 5, 242 },
                    { 4, 242 },
                    { 5, 241 },
                    { 1, 77 },
                    { 7, 77 },
                    { 1, 78 },
                    { 7, 78 },
                    { 1, 79 },
                    { 7, 79 },
                    { 1, 80 },
                    { 7, 80 },
                    { 1, 81 },
                    { 7, 81 },
                    { 1, 82 },
                    { 7, 82 },
                    { 7, 76 },
                    { 1, 83 },
                    { 1, 84 },
                    { 7, 84 },
                    { 1, 85 },
                    { 7, 85 },
                    { 1, 86 },
                    { 7, 86 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 1, 87 },
                    { 7, 87 },
                    { 1, 88 },
                    { 7, 88 },
                    { 1, 89 },
                    { 7, 89 },
                    { 7, 83 },
                    { 1, 90 },
                    { 1, 76 },
                    { 1, 75 },
                    { 1, 62 },
                    { 7, 62 },
                    { 1, 63 },
                    { 7, 63 },
                    { 1, 64 },
                    { 7, 64 },
                    { 1, 65 },
                    { 7, 65 },
                    { 1, 66 },
                    { 7, 66 },
                    { 1, 67 },
                    { 7, 67 },
                    { 7, 75 },
                    { 1, 68 },
                    { 1, 69 },
                    { 7, 69 },
                    { 1, 70 },
                    { 7, 70 },
                    { 1, 71 },
                    { 7, 71 },
                    { 1, 72 },
                    { 7, 72 },
                    { 1, 73 },
                    { 7, 73 },
                    { 1, 74 },
                    { 7, 74 },
                    { 7, 68 },
                    { 7, 90 },
                    { 1, 91 },
                    { 7, 91 },
                    { 7, 107 },
                    { 1, 108 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 7, 108 },
                    { 1, 109 },
                    { 7, 109 },
                    { 1, 110 },
                    { 7, 110 },
                    { 1, 111 },
                    { 7, 111 },
                    { 1, 112 },
                    { 7, 112 },
                    { 1, 113 },
                    { 1, 107 },
                    { 7, 113 },
                    { 7, 114 },
                    { 1, 115 },
                    { 7, 115 },
                    { 1, 116 },
                    { 7, 116 },
                    { 1, 117 },
                    { 7, 117 },
                    { 1, 118 },
                    { 7, 118 },
                    { 1, 119 },
                    { 7, 119 },
                    { 1, 120 },
                    { 1, 114 },
                    { 7, 106 },
                    { 1, 106 },
                    { 7, 105 },
                    { 1, 92 },
                    { 7, 92 },
                    { 1, 93 },
                    { 7, 93 },
                    { 1, 94 },
                    { 7, 94 },
                    { 1, 95 },
                    { 7, 95 },
                    { 1, 96 },
                    { 7, 96 },
                    { 1, 97 },
                    { 7, 97 },
                    { 1, 98 },
                    { 7, 98 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 1, 99 },
                    { 7, 99 },
                    { 1, 100 },
                    { 7, 100 },
                    { 1, 101 },
                    { 7, 101 },
                    { 1, 102 },
                    { 7, 102 },
                    { 1, 103 },
                    { 7, 103 },
                    { 1, 104 },
                    { 7, 104 },
                    { 1, 105 },
                    { 7, 61 },
                    { 7, 120 },
                    { 1, 61 },
                    { 1, 60 },
                    { 7, 16 },
                    { 1, 17 },
                    { 7, 17 },
                    { 1, 18 },
                    { 7, 18 },
                    { 1, 19 },
                    { 7, 19 },
                    { 1, 20 },
                    { 7, 20 },
                    { 1, 21 },
                    { 7, 21 },
                    { 1, 22 },
                    { 1, 16 },
                    { 7, 22 },
                    { 7, 23 },
                    { 1, 24 },
                    { 7, 24 },
                    { 1, 25 },
                    { 7, 25 },
                    { 1, 26 },
                    { 7, 26 },
                    { 1, 27 },
                    { 7, 27 },
                    { 1, 28 },
                    { 7, 28 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 1, 29 },
                    { 1, 23 },
                    { 7, 29 },
                    { 7, 15 },
                    { 7, 14 },
                    { 7, 1 },
                    { 1, 2 },
                    { 7, 2 },
                    { 1, 3 },
                    { 7, 3 },
                    { 1, 4 },
                    { 7, 4 },
                    { 1, 5 },
                    { 7, 5 },
                    { 1, 6 },
                    { 7, 6 },
                    { 1, 7 },
                    { 1, 15 },
                    { 7, 7 },
                    { 7, 8 },
                    { 1, 9 },
                    { 7, 9 },
                    { 1, 10 },
                    { 7, 10 },
                    { 1, 11 },
                    { 7, 11 },
                    { 1, 12 },
                    { 7, 12 },
                    { 1, 13 },
                    { 7, 13 },
                    { 1, 14 },
                    { 1, 8 },
                    { 1, 30 },
                    { 7, 30 },
                    { 1, 31 },
                    { 1, 47 },
                    { 7, 47 },
                    { 1, 48 },
                    { 7, 48 },
                    { 1, 49 },
                    { 7, 49 },
                    { 1, 50 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 7, 50 },
                    { 1, 51 },
                    { 7, 51 },
                    { 1, 52 },
                    { 7, 52 },
                    { 7, 46 },
                    { 1, 53 },
                    { 1, 54 },
                    { 7, 54 },
                    { 1, 55 },
                    { 7, 55 },
                    { 1, 56 },
                    { 7, 56 },
                    { 1, 57 },
                    { 7, 57 },
                    { 1, 58 },
                    { 7, 58 },
                    { 1, 59 },
                    { 7, 59 },
                    { 7, 53 },
                    { 1, 46 },
                    { 7, 45 },
                    { 1, 45 },
                    { 7, 31 },
                    { 1, 32 },
                    { 7, 32 },
                    { 1, 33 },
                    { 7, 33 },
                    { 1, 34 },
                    { 7, 34 },
                    { 1, 35 },
                    { 7, 35 },
                    { 1, 36 },
                    { 7, 36 },
                    { 1, 37 },
                    { 7, 37 },
                    { 1, 38 },
                    { 7, 38 },
                    { 1, 39 },
                    { 7, 39 },
                    { 1, 40 },
                    { 7, 40 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 1, 41 },
                    { 7, 41 },
                    { 1, 42 },
                    { 7, 42 },
                    { 1, 43 },
                    { 7, 43 },
                    { 1, 44 },
                    { 7, 44 },
                    { 7, 60 },
                    { 4, 483 },
                    { 1, 121 },
                    { 1, 122 },
                    { 3, 198 },
                    { 5, 198 },
                    { 3, 199 },
                    { 5, 199 },
                    { 3, 200 },
                    { 5, 200 },
                    { 3, 201 },
                    { 5, 201 },
                    { 3, 202 },
                    { 5, 202 },
                    { 3, 203 },
                    { 5, 203 },
                    { 5, 197 },
                    { 3, 204 },
                    { 3, 205 },
                    { 5, 205 },
                    { 3, 206 },
                    { 5, 206 },
                    { 3, 207 },
                    { 5, 207 },
                    { 3, 208 },
                    { 5, 208 },
                    { 3, 209 },
                    { 5, 209 },
                    { 3, 210 },
                    { 5, 210 },
                    { 5, 204 },
                    { 3, 211 },
                    { 3, 197 },
                    { 3, 196 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 3, 183 },
                    { 5, 183 },
                    { 3, 184 },
                    { 5, 184 },
                    { 3, 185 },
                    { 5, 185 },
                    { 3, 186 },
                    { 5, 186 },
                    { 3, 187 },
                    { 5, 187 },
                    { 3, 188 },
                    { 5, 188 },
                    { 5, 196 },
                    { 3, 189 },
                    { 3, 190 },
                    { 5, 190 },
                    { 3, 191 },
                    { 5, 191 },
                    { 3, 192 },
                    { 5, 192 },
                    { 3, 193 },
                    { 5, 193 },
                    { 3, 194 },
                    { 5, 194 },
                    { 3, 195 },
                    { 5, 195 },
                    { 5, 189 },
                    { 5, 211 },
                    { 3, 212 },
                    { 5, 212 },
                    { 5, 228 },
                    { 4, 229 },
                    { 5, 229 },
                    { 4, 230 },
                    { 5, 230 },
                    { 4, 231 },
                    { 5, 231 },
                    { 4, 232 },
                    { 5, 232 },
                    { 4, 233 },
                    { 5, 233 },
                    { 4, 234 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 4, 228 },
                    { 5, 234 },
                    { 5, 235 },
                    { 4, 236 },
                    { 5, 236 },
                    { 4, 237 },
                    { 5, 237 },
                    { 4, 238 },
                    { 5, 238 },
                    { 4, 239 },
                    { 5, 239 },
                    { 4, 240 },
                    { 5, 240 },
                    { 4, 241 },
                    { 4, 235 },
                    { 5, 227 },
                    { 4, 227 },
                    { 5, 226 },
                    { 3, 213 },
                    { 5, 213 },
                    { 3, 214 },
                    { 5, 214 },
                    { 3, 215 },
                    { 5, 215 },
                    { 3, 216 },
                    { 5, 216 },
                    { 3, 217 },
                    { 5, 217 },
                    { 4, 218 },
                    { 5, 218 },
                    { 4, 219 },
                    { 5, 219 },
                    { 4, 220 },
                    { 5, 220 },
                    { 4, 221 },
                    { 5, 221 },
                    { 4, 222 },
                    { 5, 222 },
                    { 4, 223 },
                    { 5, 223 },
                    { 4, 224 },
                    { 5, 224 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 4, 225 },
                    { 5, 225 },
                    { 4, 226 },
                    { 5, 182 },
                    { 7, 121 },
                    { 3, 182 },
                    { 3, 181 },
                    { 5, 137 },
                    { 2, 138 },
                    { 5, 138 },
                    { 2, 139 },
                    { 5, 139 },
                    { 2, 140 },
                    { 5, 140 },
                    { 2, 141 },
                    { 5, 141 },
                    { 2, 142 },
                    { 5, 142 },
                    { 2, 143 },
                    { 2, 137 },
                    { 5, 143 },
                    { 5, 144 },
                    { 2, 145 },
                    { 5, 145 },
                    { 2, 146 },
                    { 5, 146 },
                    { 2, 147 },
                    { 5, 147 },
                    { 3, 148 },
                    { 5, 148 },
                    { 3, 149 },
                    { 5, 149 },
                    { 3, 150 },
                    { 2, 144 },
                    { 5, 150 },
                    { 5, 136 },
                    { 5, 135 },
                    { 7, 122 },
                    { 1, 123 },
                    { 7, 123 },
                    { 1, 124 },
                    { 7, 124 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 1, 125 },
                    { 7, 125 },
                    { 1, 126 },
                    { 7, 126 },
                    { 1, 127 },
                    { 7, 127 },
                    { 1, 128 },
                    { 2, 136 },
                    { 7, 128 },
                    { 7, 129 },
                    { 1, 130 },
                    { 7, 130 },
                    { 1, 131 },
                    { 7, 131 },
                    { 1, 132 },
                    { 7, 132 },
                    { 1, 133 },
                    { 7, 133 },
                    { 2, 134 },
                    { 5, 134 },
                    { 2, 135 },
                    { 1, 129 },
                    { 3, 151 },
                    { 5, 151 },
                    { 3, 152 },
                    { 3, 168 },
                    { 5, 168 },
                    { 3, 169 },
                    { 5, 169 },
                    { 3, 170 },
                    { 5, 170 },
                    { 3, 171 },
                    { 5, 171 },
                    { 3, 172 },
                    { 5, 172 },
                    { 3, 173 },
                    { 5, 173 },
                    { 5, 167 },
                    { 3, 174 },
                    { 3, 175 },
                    { 5, 175 },
                    { 3, 176 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoryID", "ProductsProductID" },
                values: new object[,]
                {
                    { 5, 176 },
                    { 3, 177 },
                    { 5, 177 },
                    { 3, 178 },
                    { 5, 178 },
                    { 3, 179 },
                    { 5, 179 },
                    { 3, 180 },
                    { 5, 180 },
                    { 5, 174 },
                    { 3, 167 },
                    { 5, 166 },
                    { 3, 166 },
                    { 5, 152 },
                    { 3, 153 },
                    { 5, 153 },
                    { 3, 154 },
                    { 5, 154 },
                    { 3, 155 },
                    { 5, 155 },
                    { 3, 156 },
                    { 5, 156 },
                    { 3, 157 },
                    { 5, 157 },
                    { 3, 158 },
                    { 5, 158 },
                    { 3, 159 },
                    { 5, 159 },
                    { 3, 160 },
                    { 5, 160 },
                    { 3, 161 },
                    { 5, 161 },
                    { 3, 162 },
                    { 5, 162 },
                    { 3, 163 },
                    { 5, 163 },
                    { 3, 164 },
                    { 5, 164 },
                    { 3, 165 },
                    { 5, 165 },
                    { 5, 181 },
                    { 6, 483 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 24 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 25 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 26 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 27 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 28 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 29 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 30 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 31 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 32 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 33 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 34 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 35 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 36 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 37 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 38 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 39 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 40 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 41 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 42 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 43 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 44 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 45 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 46 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 47 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 48 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 49 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 50 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 51 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 52 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 53 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 54 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 55 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 56 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 57 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 58 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 59 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 60 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 61 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 62 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 63 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 64 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 65 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 66 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 67 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 68 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 69 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 70 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 71 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 72 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 73 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 74 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 75 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 76 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 77 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 78 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 79 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 80 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 81 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 82 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 83 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 84 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 85 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 86 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 87 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 88 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 89 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 90 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 91 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 92 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 93 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 94 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 95 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 96 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 97 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 98 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 99 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 100 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 101 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 102 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 103 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 104 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 105 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 106 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 107 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 108 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 109 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 110 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 111 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 112 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 113 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 114 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 115 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 116 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 117 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 118 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 119 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 120 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 121 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 122 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 123 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 124 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 125 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 126 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 127 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 128 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 129 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 130 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 131 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 132 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 1, 133 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 2, 134 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 2, 135 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 2, 136 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 2, 137 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 2, 138 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 2, 139 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 2, 140 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 2, 141 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 2, 142 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 2, 143 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 2, 144 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 2, 145 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 2, 146 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 2, 147 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 148 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 149 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 150 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 151 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 152 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 153 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 154 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 155 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 156 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 157 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 158 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 159 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 160 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 161 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 162 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 163 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 164 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 165 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 166 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 167 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 168 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 169 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 170 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 171 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 172 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 173 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 174 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 175 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 176 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 177 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 178 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 179 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 180 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 181 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 182 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 183 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 184 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 185 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 186 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 187 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 188 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 189 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 190 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 191 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 192 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 193 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 194 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 195 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 196 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 197 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 198 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 199 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 200 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 201 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 202 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 203 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 204 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 205 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 206 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 207 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 208 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 209 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 210 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 211 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 212 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 213 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 214 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 215 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 216 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 217 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 253 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 254 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 255 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 256 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 257 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 258 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 259 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 260 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 261 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 262 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 263 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 264 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 265 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 266 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 267 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 268 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 269 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 270 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 271 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 272 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 273 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 274 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 275 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 276 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 277 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 278 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 279 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 280 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 281 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 282 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 283 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 284 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 285 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 286 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 3, 287 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 218 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 219 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 220 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 221 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 222 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 223 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 224 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 225 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 226 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 227 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 228 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 229 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 230 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 231 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 232 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 233 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 234 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 235 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 236 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 237 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 238 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 239 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 240 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 241 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 242 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 243 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 244 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 245 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 246 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 247 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 248 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 249 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 250 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 251 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 252 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 288 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 289 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 290 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 291 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 292 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 293 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 294 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 295 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 296 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 297 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 298 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 299 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 300 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 301 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 302 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 303 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 304 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 305 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 306 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 307 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 308 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 309 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 310 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 311 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 312 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 313 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 314 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 315 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 316 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 317 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 318 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 319 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 320 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 321 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 322 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 323 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 324 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 325 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 326 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 327 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 328 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 329 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 330 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 331 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 332 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 333 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 334 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 335 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 336 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 337 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 338 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 339 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 340 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 341 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 342 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 343 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 344 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 345 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 346 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 347 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 348 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 349 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 350 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 351 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 352 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 353 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 354 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 355 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 356 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 357 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 358 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 359 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 360 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 361 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 362 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 363 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 364 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 365 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 366 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 367 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 368 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 369 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 370 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 371 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 372 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 373 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 374 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 375 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 376 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 377 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 378 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 379 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 380 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 381 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 382 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 383 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 384 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 385 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 386 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 387 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 388 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 389 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 390 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 391 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 392 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 393 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 394 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 395 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 396 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 397 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 398 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 399 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 400 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 401 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 402 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 403 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 404 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 405 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 406 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 407 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 408 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 409 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 410 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 411 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 412 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 413 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 414 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 415 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 416 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 417 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 418 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 419 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 420 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 421 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 422 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 423 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 424 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 425 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 426 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 427 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 428 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 429 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 430 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 431 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 432 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 433 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 434 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 435 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 436 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 437 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 438 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 439 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 440 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 441 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 442 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 443 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 444 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 445 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 446 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 447 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 448 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 449 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 450 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 451 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 452 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 453 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 454 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 455 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 456 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 457 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 458 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 459 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 460 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 461 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 462 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 463 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 464 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 465 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 466 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 467 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 468 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 469 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 470 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 471 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 472 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 473 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 474 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 475 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 476 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 477 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 478 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 479 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 480 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 481 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 482 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 4, 483 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 134 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 135 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 136 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 137 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 138 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 139 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 140 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 141 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 142 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 143 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 144 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 145 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 146 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 147 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 148 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 149 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 150 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 151 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 152 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 153 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 154 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 155 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 156 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 157 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 158 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 159 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 160 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 161 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 162 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 163 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 164 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 165 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 166 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 167 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 168 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 169 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 170 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 171 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 172 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 173 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 174 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 175 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 176 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 177 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 178 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 179 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 180 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 181 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 182 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 183 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 184 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 185 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 186 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 187 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 188 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 189 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 190 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 191 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 192 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 193 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 194 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 195 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 196 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 197 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 198 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 199 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 200 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 201 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 202 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 203 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 204 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 205 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 206 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 207 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 208 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 209 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 210 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 211 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 212 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 213 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 214 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 215 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 216 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 217 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 218 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 219 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 220 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 221 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 222 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 223 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 224 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 225 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 226 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 227 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 228 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 229 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 230 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 231 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 232 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 233 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 234 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 235 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 236 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 237 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 238 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 239 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 240 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 241 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 242 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 243 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 244 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 245 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 246 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 247 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 248 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 249 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 250 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 251 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 252 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 253 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 254 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 255 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 256 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 257 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 258 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 259 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 260 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 261 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 262 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 263 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 264 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 265 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 266 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 267 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 268 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 269 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 270 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 271 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 272 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 273 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 274 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 275 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 276 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 277 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 278 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 279 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 280 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 281 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 282 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 283 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 284 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 285 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 286 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 287 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 288 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 289 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 290 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 291 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 292 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 293 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 294 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 295 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 296 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 297 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 298 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 299 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 300 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 301 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 302 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 303 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 304 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 305 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 306 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 307 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 308 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 309 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 310 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 311 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 312 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 313 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 314 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 315 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 316 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 317 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 318 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 319 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 320 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 321 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 322 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 323 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 324 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 325 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 326 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 327 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 328 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 329 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 330 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 331 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 332 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 333 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 334 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 335 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 336 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 337 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 338 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 339 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 340 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 341 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 342 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 343 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 344 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 345 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 346 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 347 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 348 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 349 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 5, 350 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 351 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 352 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 353 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 354 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 355 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 356 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 357 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 358 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 359 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 360 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 361 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 362 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 363 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 364 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 365 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 366 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 367 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 368 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 369 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 370 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 371 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 372 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 373 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 374 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 375 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 376 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 377 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 378 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 379 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 380 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 381 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 382 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 383 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 384 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 385 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 386 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 387 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 388 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 389 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 390 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 391 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 392 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 393 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 394 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 395 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 396 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 397 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 398 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 399 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 400 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 401 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 402 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 403 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 404 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 405 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 406 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 407 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 408 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 409 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 410 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 411 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 412 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 413 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 414 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 415 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 416 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 417 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 418 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 419 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 420 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 421 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 422 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 423 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 424 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 425 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 426 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 427 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 428 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 429 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 430 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 431 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 432 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 433 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 434 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 435 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 436 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 437 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 438 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 439 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 440 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 441 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 442 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 443 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 444 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 445 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 446 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 447 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 448 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 449 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 450 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 451 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 452 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 453 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 454 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 455 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 456 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 457 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 458 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 459 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 460 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 461 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 462 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 463 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 464 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 465 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 466 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 467 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 468 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 469 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 470 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 471 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 472 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 473 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 474 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 475 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 476 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 477 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 478 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 479 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 480 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 481 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 482 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 6, 483 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 11 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 14 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 15 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 17 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 18 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 19 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 20 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 21 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 22 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 23 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 24 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 25 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 26 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 27 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 28 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 29 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 30 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 31 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 32 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 33 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 34 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 35 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 36 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 37 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 38 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 39 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 40 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 41 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 42 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 43 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 44 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 45 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 46 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 47 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 48 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 49 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 50 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 51 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 52 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 53 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 54 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 55 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 56 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 57 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 58 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 59 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 60 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 61 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 62 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 63 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 64 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 65 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 66 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 67 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 68 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 69 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 70 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 71 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 72 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 73 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 74 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 75 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 76 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 77 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 78 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 79 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 80 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 81 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 82 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 83 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 84 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 85 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 86 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 87 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 88 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 89 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 90 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 91 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 92 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 93 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 94 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 95 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 96 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 97 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 98 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 99 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 100 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 101 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 102 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 103 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 104 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 105 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 106 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 107 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 108 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 109 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 110 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 111 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 112 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 113 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 114 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 115 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 116 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 117 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 118 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 119 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 120 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 121 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 122 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 123 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 124 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 125 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 126 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 127 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 128 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 129 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 130 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 131 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 132 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoryID", "ProductsProductID" },
                keyValues: new object[] { 7, 133 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 483);
        }
    }
}
