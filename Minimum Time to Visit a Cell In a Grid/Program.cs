﻿using Minimum_Time_to_Visit_a_Cell_In_a_Grid;

Solution solution = new();
Console.WriteLine(solution.MinimumTime([[0, 1, 3, 2], [5, 1, 2, 5], [4, 3, 8, 6]]));
Console.WriteLine(solution.MinimumTime([[0, 2, 4], [3, 2, 1], [1, 0, 4]]));
Console.WriteLine(solution.MinimumTime([[0, 1, 4878, 45087, 56590, 38472, 56784, 14057, 82345, 17038, 81843, 33419, 57002, 81714, 24418, 17645, 21746, 11394, 216, 23489, 30851, 58973], [0, 11452, 50085, 43495, 2163, 24630, 2492, 11545, 61376, 97658, 99389, 35255, 44581, 1186, 99922, 41178, 83008, 42415, 37867, 51818, 90976, 80856], [54131, 3975, 46251, 16674, 2952, 80995, 58061, 76306, 10220, 38710, 5542, 22079, 60800, 17614, 94375, 21989, 5476, 56266, 45396, 85921, 36868, 21851], [22676, 71167, 16511, 69380, 7705, 82660, 34097, 96081, 31995, 44906, 93612, 64755, 68639, 22905, 61417, 16224, 83532, 58986, 7067, 10464, 25850, 30692], [86415, 51634, 34212, 77392, 70305, 11241, 68322, 36010, 97951, 39885, 70478, 27980, 90788, 65248, 25302, 78895, 84977, 37995, 93712, 69777, 90873, 35307], [74583, 42328, 451, 93466, 92549, 17980, 49758, 23340, 9068, 92732, 46021, 40235, 89351, 69451, 66016, 43908, 41550, 36786, 49494, 88173, 43972, 7906], [58157, 25235, 17889, 57134, 81808, 16331, 12199, 85480, 6688, 52203, 52567, 71122, 15115, 28676, 40458, 8294, 51056, 33744, 47000, 13873, 2021, 24457], [55026, 14592, 32347, 54307, 13459, 85147, 31201, 24311, 18840, 43143, 65360, 66506, 29182, 36181, 95053, 40661, 16957, 5327, 81323, 14773, 33222, 88004], [8468, 9687, 76498, 17914, 56774, 66020, 92301, 84045, 1547, 50620, 91696, 47237, 43850, 2554, 57002, 61981, 42623, 72264, 26259, 66675, 55798, 15557], [22621, 16586, 64643, 37486, 90965, 77554, 38432, 31022, 88705, 75120, 53592, 78601, 95947, 50674, 28544, 80460, 17194, 69544, 30634, 91044, 25639, 12287], [54402, 13547, 80468, 69492, 82906, 42166, 70425, 22569, 51167, 20128, 81310, 11083, 1032, 58114, 3763, 16736, 58119, 63694, 78792, 14572, 17765, 77821], [9718, 65682, 16970, 68902, 60043, 2594, 65421, 57892, 73587, 62900, 50394, 20562, 14665, 95063, 27598, 52184, 6027, 52222, 30886, 79958, 39819, 38741], [19099, 59524, 3315, 75444, 80862, 40422, 12795, 49040, 17178, 34559, 80456, 4405, 63924, 81159, 59587, 16024, 93422, 10810, 84263, 72633, 53665, 81036], [78449, 44654, 83219, 62788, 26975, 47224, 2092, 21644, 46528, 35202, 67615, 67442, 33395, 11508, 46091, 9521, 582, 63920, 73795, 74916, 95566, 26105], [14869, 49434, 22746, 24444, 65527, 46613, 38512, 31183, 82025, 45808, 74179, 4363, 47366, 93953, 43969, 88676, 64666, 925, 9185, 15151, 56023, 55929], [89323, 30379, 92263, 63922, 8318, 89856, 93738, 22939, 50777, 41672, 80241, 90236, 59193, 89944, 29739, 99598, 40618, 24562, 8776, 7527, 19248, 83804], [90669, 6203, 81025, 18848, 92968, 76534, 18936, 13160, 63555, 24669, 29290, 48745, 53432, 57581, 37313, 80064, 63117, 72121, 64218, 46880, 36482, 30040], [94250, 70515, 67791, 28905, 92521, 41420, 41106, 74492, 39549, 37276, 99175, 13475, 18288, 55860, 30295, 47170, 65099, 49314, 26714, 38730, 80870, 82670], [63263, 45256, 87750, 17599, 74523, 43891, 3962, 78875, 56288, 63238, 86537, 52863, 47837, 76217, 90500, 99348, 48631, 7635, 84746, 67463, 15101, 51874], [71723, 94684, 32390, 22403, 91021, 35151, 81917, 71937, 46990, 52993, 68216, 87442, 8925, 69203, 36560, 83178, 57537, 50422, 99242, 42515, 45589, 71406], [73375, 24376, 17836, 73999, 43277, 51679, 62284, 98347, 54589, 56207, 14220, 28192, 56429, 90208, 8867, 24269, 59257, 3380, 21951, 22450, 70601, 55867], [52944, 15251, 44909, 39640, 6446, 5093, 63283, 43409, 93575, 63695, 55848, 53286, 5345, 56623, 20288, 67479, 81341, 34073, 70393, 55611, 2024, 81310], [35120, 5870, 73730, 56499, 5210, 697, 31186, 78875, 61613, 45328, 82421, 21324, 59181, 38089, 54183, 53005, 20508, 26109, 42741, 13741, 31980, 60478], [41228, 74313, 84408, 43297, 92441, 84522, 69491, 83055, 43394, 64349, 89987, 10736, 75653, 25905, 16125, 99240, 43239, 82443, 42553, 92878, 39409, 98284], [93691, 4641, 17706, 85628, 60471, 11068, 49252, 52541, 39807, 81505, 38150, 95817, 66330, 96015, 36769, 69769, 74297, 42909, 27049, 21372, 77639, 33909], [61954, 94532, 51637, 45916, 90, 67173, 22028, 2313, 82986, 48424, 51360, 3797, 13082, 60783, 85022, 21692, 80798, 77425, 18905, 21340, 72174, 39853], [75192, 67167, 24437, 98215, 8569, 78455, 82893, 65762, 45384, 89370, 63036, 56729, 33580, 34845, 45282, 46728, 55480, 25678, 85986, 43006, 36945, 86507], [55820, 28761, 8755, 89101, 57300, 54310, 79463, 81737, 26655, 17992, 24877, 50168, 20019, 77669, 91222, 30079, 11746, 18982, 33205, 52354, 89398, 18840], [36733, 6696, 50323, 5505, 66612, 45146, 36997, 11749, 53167, 38814, 40508, 52921, 96704, 95085, 33638, 90510, 89676, 67519, 98809, 55185, 26649, 13607], [77541, 22117, 6413, 19346, 98865, 93167, 70181, 35471, 44150, 22922, 36136, 8506, 7544, 11016, 86816, 81218, 54556, 11877, 90837, 79078, 24030, 90798], [30672, 28364, 15381, 55910, 13764, 29887, 40104, 18796, 94301, 67405, 79321, 40240, 77274, 37154, 97384, 43511, 294, 19415, 96295, 84883, 3587, 28651], [4059, 88606, 28241, 62924, 34527, 73721, 89648, 80088, 11986, 78444, 96271, 971, 77482, 47757, 65987, 91410, 70009, 22579, 89793, 44314, 44093, 26527], [58190, 77256, 29293, 63118, 55062, 40175, 50610, 2559, 65587, 51089, 71831, 34581, 3966, 11514, 56081, 92300, 63593, 41491, 16935, 13063, 86056, 35488], [12213, 10994, 45367, 69518, 59047, 95016, 95783, 55910, 27113, 87870, 20387, 11200, 44707, 80186, 41078, 79188, 28908, 40415, 17772, 95143, 18041, 83759], [21295, 32819, 46893, 21038, 74759, 85068, 67265, 27077, 32848, 59877, 43125, 35470, 57845, 30714, 24376, 46829, 92699, 70111, 32478, 77004, 77166, 46934], [11423, 66918, 93859, 79878, 20327, 70213, 37550, 39969, 41052, 25330, 2325, 4186, 79414, 15240, 88417, 45766, 72066, 25529, 80567, 91173, 56173, 33955], [60936, 73247, 47058, 77418, 86458, 63820, 78677, 17241, 3892, 68955, 11801, 73419, 84090, 66532, 87623, 32945, 84094, 47438, 41248, 3941, 97489, 55970], [55324, 53168, 1653, 52537, 69935, 15126, 20289, 68078, 22005, 71389, 42594, 47001, 53996, 83562, 74954, 60552, 44854, 94131, 11965, 77187, 86952, 52225], [17957, 76781, 53770, 95084, 26279, 56508, 96357, 10587, 45675, 4969, 86665, 40118, 30371, 30243, 57623, 25704, 70954, 70219, 39958, 10325, 43232, 84542], [40273, 7468, 20600, 34041, 24488, 19756, 18940, 4559, 61981, 24252, 42272, 96324, 10543, 59616, 89404, 42089, 77938, 20943, 52586, 90118, 74197, 84417], [93966, 49271, 13965, 98940, 77294, 82902, 47048, 26752, 47702, 61131, 13161, 78831, 8928, 83221, 78663, 10608, 19798, 17874, 25574, 37280, 21232, 50852], [18460, 86734, 31377, 15202, 55068, 64296, 89845, 56482, 82347, 71362, 84547, 26549, 22487, 66767, 43811, 61627, 8191, 56717, 97027, 63665, 91006, 94808], [42129, 77103, 60377, 60287, 87621, 6095, 12158, 2430, 25253, 24678, 48886, 56864, 36699, 28211, 83543, 22428, 34895, 11480, 96071, 28991, 8586, 16593], [85238, 54658, 49469, 19988, 48335, 18652, 3707, 47889, 13308, 27978, 35966, 35068, 4167, 70302, 10062, 91246, 30799, 15139, 55139, 85812, 43649, 40642], [85944, 44384, 87529, 64456, 43518, 4908, 36980, 79044, 19389, 80735, 58192, 805, 42905, 3391, 35697, 16414, 30351, 42174, 8993, 86688, 56777, 10357], [51659, 47130, 65978, 88775, 28627, 66408, 14995, 55314, 53253, 93488, 40708, 21334, 88035, 34477, 96762, 50842, 6271, 81667, 96690, 84503, 45526, 11249], [28918, 555, 41485, 69318, 5838, 56204, 50431, 96989, 88977, 30030, 10739, 60997, 23885, 39036, 54298, 29773, 79808, 28687, 55518, 95457, 35971, 82987], [10910, 14774, 43768, 57989, 54682, 2028, 25873, 70798, 25, 27562, 32353, 49013, 62456, 65641, 91201, 44010, 82412, 89698, 68085, 43377, 24650, 41344], [42502, 39064, 87643, 88942, 10155, 19882, 77427, 41699, 82346, 59626, 87135, 39197, 13436, 32550, 88425, 60564, 80638, 6002, 68284, 32996, 50101, 20255], [60395, 82186, 61922, 8992, 82123, 5747, 3514, 38141, 20799, 3407, 77886, 68984, 11615, 79189, 6256, 16440, 82809, 26134, 21688, 74911, 51188, 63867], [29713, 25003, 65497, 60609, 34672, 38423, 67162, 37421, 23058, 77796, 12574, 76022, 67545, 18871, 91369, 95193, 58606, 12194, 82016, 70988, 31719, 11449], [75740, 12874, 89308, 97961, 37418, 72937, 60976, 70780, 25337, 88931, 69693, 98184, 96687, 53785, 46732, 7941, 36583, 28849, 17299, 52044, 33983, 80704], [47666, 36984, 20696, 16795, 69521, 84328, 15387, 32855, 27790, 45448, 38555, 68626, 13341, 75897, 87026, 18732, 65189, 25788, 16036, 57095, 21363, 37601], [36140, 99354, 45490, 96714, 10308, 46448, 19508, 62263, 56542, 11989, 64910, 12503, 57170, 54304, 18917, 50833, 78280, 65814, 29771, 59299, 9674, 39420], [86469, 85918, 53143, 54541, 73339, 79877, 97696, 61785, 88155, 91544, 11109, 59773, 14927, 87775, 36539, 31984, 84130, 27308, 91958, 59174, 2392, 52388], [30195, 23957, 13357, 17140, 21828, 99322, 10535, 88789, 72634, 87180, 57222, 82359, 19662, 34498, 11719, 44350, 18266, 92730, 46772, 62219, 13752, 75178], [73993, 25085, 26378, 10934, 64854, 21008, 98151, 3345, 13050, 29012, 53540, 6339, 21337, 71077, 96710, 2912, 72175, 73362, 79802, 37661, 56772, 75489], [44330, 4628, 78244, 62270, 87063, 64163, 36478, 78730, 52365, 9392, 683, 2226, 31804, 98755, 87709, 93231, 83011, 27310, 83149, 12286, 20273, 59480], [84518, 90166, 1363, 67938, 51927, 61722, 50093, 33788, 2645, 12487, 65623, 6553, 29016, 2930, 29967, 81363, 7493, 54191, 58074, 88111, 35349, 55378], [6696, 64006, 11910, 34258, 8881, 90157, 90809, 86954, 7580, 88851, 46983, 34964, 75879, 99411, 96029, 927, 76935, 50668, 83523, 62327, 68542, 7313], [57958, 35824, 72773, 34323, 58678, 96871, 5415, 8914, 14690, 75037, 70207, 6963, 51039, 92821, 52703, 342, 94646, 28476, 75205, 60888, 95648, 92660], [96228, 56249, 53581, 91024, 64747, 50484, 44271, 5011, 8313, 4474, 82070, 27140, 77997, 55394, 13303, 62740, 72252, 23923, 79793, 45753, 36149, 29062], [64073, 43286, 84849, 27226, 87568, 93861, 99801, 9659, 43814, 61354, 82106, 60419, 66272, 10228, 45147, 14154, 7389, 558, 58380, 5539, 18175, 33151], [46400, 55433, 98008, 86464, 4777, 94539, 20676, 65404, 19597, 17224, 89117, 7524, 40928, 76529, 59184, 26372, 35539, 70005, 70235, 27116, 95173, 92053], [20550, 20962, 29228, 31887, 23156, 54435, 11157, 26840, 70953, 29098, 35650, 36959, 51908, 27593, 4993, 45299, 12456, 93523, 34578, 60814, 23914, 56714], [60556, 74303, 90780, 92479, 16467, 61307, 32784, 53365, 52122, 54524, 94357, 31282, 56443, 86418, 79540, 95276, 88059, 23687, 98117, 18731, 3365, 38229], [48374, 69530, 95077, 86482, 12823, 65674, 52801, 67837, 35957, 47628, 93508, 80910, 76990, 84205, 63167, 9888, 84951, 35595, 80197, 7394, 11462, 43070], [17851, 1719, 59309, 74883, 19167, 22566, 98460, 32706, 81482, 96065, 64713, 93145, 90594, 72972, 33939, 54747, 59299, 48054, 6286, 67031, 13985, 81102], [90023, 67146, 78285, 45871, 27384, 42164, 17572, 99467, 46631, 21943, 61365, 71773, 67839, 69263, 25379, 241, 15723, 39738, 57719, 9326, 30747, 85760], [26354, 79132, 43702, 33068, 61650, 96015, 82199, 3800, 65368, 66270, 65030, 37947, 89216, 53767, 85968, 83222, 16368, 90985, 42483, 9103, 5278, 29331], [9094, 43907, 58917, 46638, 74598, 82696, 86337, 75757, 17081, 5316, 72563, 35688, 57560, 46846, 37840, 22955, 22018, 41986, 17444, 33937, 22878, 25086], [80678, 15545, 45522, 37929, 15245, 59298, 4831, 71692, 58266, 38299, 18611, 12204, 68980, 94256, 77670, 14307, 38040, 17575, 26736, 88634, 26380, 26779], [71963, 59937, 81851, 35977, 87673, 68616, 78172, 14082, 84027, 72727, 63735, 70907, 24625, 74371, 76387, 71845, 61590, 44393, 1450, 28426, 58469, 92352], [17728, 41374, 82025, 51310, 53381, 81989, 3212, 86516, 61909, 15363, 68270, 21614, 99042, 37270, 8708, 53364, 2300, 54261, 89833, 7681, 25869, 25366], [50821, 71674, 41814, 50749, 27562, 99356, 72076, 16973, 38863, 44481, 703, 36066, 74365, 12191, 66014, 75141, 71918, 79738, 5327, 14255, 13901, 54332], [19440, 39172, 23144, 57858, 20437, 89798, 27920, 70888, 84083, 60127, 68332, 73209, 40280, 14831, 25055, 39723, 66673, 36650, 37961, 38188, 73397, 68668], [59628, 93487, 90922, 48595, 67492, 27477, 29950, 33956, 21923, 44758, 51379, 15187, 60353, 36501, 91945, 361, 73727, 28589, 81386, 98937, 54482, 82324], [2884, 27889, 65184, 97101, 46240, 43679, 56817, 6811, 77530, 87062, 10882, 39246, 71974, 84923, 49851, 16401, 33633, 71109, 59604, 86549, 88723, 87023], [17487, 44579, 66797, 93512, 24551, 3696, 31058, 1294, 70832, 72388, 81117, 84561, 58907, 68282, 51589, 17136, 31265, 18430, 96723, 91522, 51100, 91198]]));
Console.WriteLine(solution.MinimumTime([[0, 0, 75279, 1642, 27457, 30604, 38417, 26675, 29038, 10326, 25278, 98093, 77340, 54624, 79814, 4133, 13043, 13841, 36641, 54220, 82697, 3483, 96513, 79224, 28545, 18198, 61210, 24974, 78210, 89404, 91761, 99803, 79186, 41826, 35240, 81711, 60315, 72841, 70871, 64679, 83936, 7759], [1, 15637, 55696, 34259, 27045, 81860, 78351, 72206, 43174, 12686, 73102, 30436, 17128, 70522, 51128, 21807, 31252, 20718, 73992, 53662, 97649, 57769, 39437, 82098, 69106, 72013, 17717, 11308, 95048, 31526, 22200, 81566, 98469, 61353, 64383, 56666, 80054, 29661, 15844, 9739, 39492, 54327], [1805, 52060, 39416, 3251, 43939, 71498, 28822, 24255, 23192, 22525, 46084, 70072, 66250, 76304, 17197, 75876, 85370, 25905, 49952, 61352, 13896, 13531, 91169, 46407, 64233, 97963, 26544, 58057, 40096, 4112, 67029, 33963, 26019, 83477, 82992, 55191, 98120, 46011, 64343, 72872, 31649, 12305], [22897, 89110, 59602, 93840, 89423, 10930, 10174, 94340, 54010, 18975, 68079, 1499, 17783, 30715, 91702, 88578, 16495, 55462, 59211, 82804, 94416, 21425, 62267, 91326, 57711, 66526, 20241, 90105, 35844, 76721, 45549, 33670, 65961, 25596, 71508, 14661, 20583, 8051, 10192, 93607, 79938, 70339], [28450, 16903, 26570, 66652, 95273, 59008, 96488, 6776, 70022, 98679, 28267, 63937, 75902, 65050, 39799, 70389, 34263, 21599, 77630, 17005, 12034, 55569, 21719, 81143, 35857, 66140, 15032, 79401, 78009, 32386, 49020, 54218, 41243, 33352, 40853, 17134, 71276, 26995, 11468, 50558, 13082, 30674], [69695, 94746, 49538, 52042, 34656, 25102, 55982, 16334, 53848, 99116, 86843, 72049, 85984, 15545, 64166, 72933, 40939, 99850, 63876, 60100, 9337, 44145, 29114, 29900, 29078, 35854, 16534, 1233, 79977, 38265, 31038, 25970, 84639, 34255, 91110, 81128, 62736, 82533, 109, 88556, 18963, 20083], [78860, 29613, 624, 45626, 48392, 23742, 32204, 27262, 85729, 98871, 90973, 80540, 15535, 13012, 60741, 25467, 88970, 86556, 47669, 8663, 29758, 78188, 7340, 46531, 15300, 96567, 1243, 7845, 66311, 8055, 43042, 44243, 52153, 72638, 54044, 26200, 90717, 14913, 2478, 29536, 98919, 44980], [23159, 53012, 97460, 40344, 16593, 7099, 41221, 84070, 12324, 64259, 80422, 49485, 86684, 1651, 98171, 52033, 69710, 16804, 357, 98086, 49044, 42621, 3008, 15951, 73597, 15962, 7568, 94277, 37266, 31396, 80442, 1004, 70079, 45180, 80397, 31771, 40794, 94855, 94588, 58347, 67059, 23214], [33797, 34062, 652, 53264, 24792, 75228, 36291, 35155, 15907, 3077, 77825, 71891, 98185, 86849, 77113, 28405, 37244, 24340, 48732, 38132, 47422, 69943, 96594, 68666, 69913, 57468, 12482, 15288, 53914, 25415, 82739, 60958, 29261, 81042, 4794, 64701, 11254, 89531, 60604, 51571, 72453, 41789], [30771, 12611, 23286, 6569, 11905, 89776, 72618, 17579, 55600, 18532, 78820, 75758, 82000, 74872, 69306, 21058, 45540, 66485, 95823, 58283, 70504, 98650, 73389, 44446, 51333, 52839, 16988, 74104, 59642, 13150, 15196, 6340, 27082, 7798, 25760, 83645, 68955, 20207, 71936, 27485, 49451, 82675], [66276, 79231, 42080, 4995, 61919, 69194, 54286, 50142, 1821, 77622, 39389, 94641, 76217, 19723, 99788, 98588, 2555, 25005, 19640, 6221, 23052, 32054, 8781, 42384, 92786, 79889, 64026, 10956, 40388, 67834, 29222, 89867, 49012, 29016, 23529, 91417, 28351, 46132, 99482, 46891, 38607, 99365], [3158, 1051, 89400, 1158, 53704, 65014, 96366, 42215, 72437, 72938, 35025, 32107, 4777, 62609, 32271, 39154, 76137, 95755, 63561, 74790, 8047, 53606, 12921, 82973, 5461, 89970, 17510, 15227, 14027, 82556, 42234, 33296, 72797, 78152, 23297, 22173, 62249, 46667, 59811, 83472, 93779, 26857], [85250, 70861, 23734, 35442, 95471, 53979, 73192, 66603, 97745, 74704, 5141, 69060, 77496, 53629, 1147, 75728, 710, 8845, 98112, 61164, 3680, 33529, 79804, 26646, 9871, 70616, 9349, 95379, 18317, 71785, 27181, 97424, 5408, 91781, 59955, 50768, 13005, 19710, 19294, 66291, 47632, 64897], [19474, 36539, 8404, 2047, 25037, 75441, 23800, 50974, 75191, 93955, 78680, 68370, 64981, 13360, 89392, 53139, 35124, 14102, 77145, 25853, 56844, 55805, 14712, 32560, 36999, 17509, 71067, 14644, 57576, 30542, 47387, 88793, 14769, 22736, 33970, 15851, 35189, 16210, 60662, 60861, 15717, 92667], [662, 72372, 64776, 81297, 95814, 46250, 21550, 21992, 72341, 88370, 24028, 67202, 51219, 54054, 40970, 28441, 172, 24860, 6729, 23058, 51462, 9587, 50254, 26295, 38238, 6432, 34895, 90283, 76645, 92979, 77996, 86623, 87791, 65097, 1697, 40692, 77820, 27321, 53730, 45320, 33413, 18644], [76654, 21586, 97697, 6721, 32735, 85679, 97796, 77781, 28541, 8283, 50966, 16214, 9736, 73031, 9064, 36494, 72238, 60991, 57656, 20695, 53749, 3140, 22384, 37735, 84719, 6585, 66710, 82836, 24138, 43538, 45036, 47145, 20748, 19069, 24586, 13255, 55162, 55362, 72204, 31235, 97320, 91134], [40415, 6657, 8042, 1966, 54286, 16367, 42751, 13719, 87890, 68513, 73574, 13191, 29848, 286, 12537, 51331, 91300, 34174, 18301, 92574, 26122, 57614, 76411, 2768, 97287, 56432, 41088, 58964, 98293, 53191, 33115, 12351, 17765, 27970, 26408, 6458, 95682, 60205, 62839, 65853, 95715, 51975], [24997, 68643, 75084, 93940, 56542, 26106, 70485, 98344, 37249, 23500, 64381, 84199, 34486, 34576, 5698, 6557, 91427, 28373, 42720, 37605, 5440, 97560, 60031, 24644, 66419, 80230, 20305, 34019, 19921, 585, 75786, 85547, 12538, 62546, 20455, 16369, 9563, 68972, 82715, 4263, 85787, 65145], [97250, 9579, 80529, 38748, 1391, 98144, 22871, 50995, 56258, 83716, 15524, 66411, 46225, 5077, 4841, 70524, 55260, 28072, 52937, 74773, 18833, 61751, 76506, 54874, 74888, 13386, 31475, 43598, 55355, 96066, 52888, 58327, 88423, 91029, 25364, 86245, 40104, 48131, 39537, 84924, 50955, 70558], [88061, 56513, 52821, 30721, 26993, 72607, 57134, 82905, 11423, 2318, 62858, 31676, 6479, 49878, 88489, 25993, 71514, 73591, 61747, 30484, 58935, 97084, 311, 47901, 97429, 9476, 10140, 73063, 51010, 16480, 24880, 34326, 27166, 12343, 36215, 52690, 70521, 99001, 41088, 27102, 38957, 18048], [10092, 81889, 13429, 82804, 36912, 22363, 98616, 3195, 36493, 75652, 1795, 78378, 55716, 18188, 51353, 38780, 43090, 55167, 63141, 91686, 72529, 51168, 56369, 80768, 19391, 87601, 32431, 42762, 84227, 274, 23460, 64349, 16855, 26289, 14601, 43425, 75178, 8600, 2837, 46827, 11248, 55902], [21935, 20641, 63474, 23792, 6653, 64567, 43687, 77825, 83996, 87518, 82289, 73488, 28829, 10837, 19545, 79353, 18783, 1510, 13399, 39174, 55732, 7910, 1367, 58312, 10944, 12885, 43636, 69325, 34121, 15611, 49295, 80521, 11061, 25185, 99317, 32432, 23173, 93432, 24444, 83417, 20245, 86752], [1793, 4748, 17962, 15778, 75191, 15980, 33535, 22603, 97316, 43122, 95371, 4250, 333, 37686, 78271, 67886, 32120, 37413, 27521, 23332, 49383, 94578, 70560, 73080, 57976, 89726, 43438, 63194, 19171, 25494, 79952, 53521, 14353, 41457, 24623, 4121, 98817, 52082, 86536, 36573, 99233, 41064], [10021, 73109, 67271, 33711, 6204, 98354, 39807, 71654, 12666, 55330, 27344, 26001, 82790, 97347, 85848, 60467, 50075, 87555, 20143, 56062, 39282, 97752, 5581, 32668, 40090, 10501, 95659, 45422, 89328, 89145, 90108, 7846, 29946, 84748, 12576, 21549, 69745, 30703, 48, 98045, 61601, 58388], [20583, 31053, 82618, 61285, 77431, 72533, 22663, 77442, 92234, 95908, 67480, 39988, 10555, 1344, 93241, 22688, 11481, 15801, 77387, 76624, 41127, 48394, 20772, 8845, 57821, 37723, 67675, 57802, 74110, 18780, 50801, 98002, 98330, 58211, 98894, 42389, 67076, 24137, 92245, 60769, 64848, 39909], [36807, 19152, 81160, 74292, 65895, 84819, 25763, 56725, 13642, 37981, 56141, 88713, 18219, 43661, 76938, 22540, 79456, 26730, 36359, 84372, 27002, 66939, 13833, 27067, 10363, 10298, 20062, 30631, 30077, 5110, 28622, 35213, 47659, 53134, 52669, 51187, 40183, 64458, 60761, 76492, 10597, 2788], [42243, 8123, 57429, 71783, 43582, 73634, 90514, 85190, 81604, 73857, 34058, 82852, 93034, 33128, 83606, 94289, 50466, 5139, 59050, 38963, 74216, 61514, 75294, 64624, 36287, 20383, 46711, 55963, 23171, 85690, 21156, 56134, 80924, 2078, 39223, 20226, 12530, 17893, 45688, 32580, 31511, 83658], [36478, 74723, 78848, 37262, 59030, 97000, 61925, 2951, 9938, 95379, 1998, 16986, 84280, 2962, 88841, 59226, 8636, 24697, 3985, 69, 98827, 45233, 26282, 76096, 7109, 48830, 72601, 54084, 50498, 12847, 80152, 95933, 75495, 96429, 43239, 66304, 82846, 67527, 17250, 17106, 39992, 39665], [91205, 85679, 83378, 46085, 9153, 20988, 15003, 13750, 2223, 94146, 51499, 97692, 44415, 91747, 78085, 86339, 50723, 30595, 89907, 67046, 52076, 50839, 2806, 5425, 38067, 75578, 99546, 1821, 2664, 78857, 24342, 61545, 65240, 50872, 10838, 38147, 75445, 50134, 90219, 27749, 50271, 7025], [43353, 42606, 43616, 35971, 75844, 66435, 5262, 24140, 76251, 58180, 68284, 21214, 83989, 45471, 35371, 95081, 4179, 30785, 16199, 74045, 58101, 15217, 29445, 59249, 7195, 48818, 78725, 27064, 77296, 9365, 335, 83041, 66317, 69737, 58130, 77123, 60228, 683, 27347, 34729, 65420, 83430], [17411, 78416, 72386, 88209, 45814, 12543, 66997, 26006, 29464, 85389, 27878, 63568, 80852, 97450, 69401, 30587, 52849, 44344, 54977, 85586, 50534, 57497, 62377, 91173, 88842, 7518, 89508, 15905, 70175, 95289, 44113, 70890, 68388, 84466, 70338, 85851, 49769, 68028, 66743, 85284, 18488, 65365], [73002, 46429, 55951, 58134, 15862, 74177, 13490, 36137, 42962, 96990, 96676, 49319, 98531, 96308, 12426, 33367, 60874, 60727, 47566, 48888, 88454, 21196, 62246, 67572, 5056, 9385, 98108, 97288, 44166, 17648, 77707, 45875, 35602, 53483, 32103, 81734, 4274, 23133, 45919, 71277, 76329, 64361], [498, 52700, 54363, 95461, 4015, 64841, 92467, 93244, 83439, 57294, 77827, 64460, 59971, 3449, 99427, 19240, 25746, 34621, 30865, 26650, 45015, 2570, 86840, 45765, 52580, 83935, 26322, 68999, 76555, 5703, 51476, 5623, 26820, 70331, 23647, 86827, 3658, 70359, 65238, 74592, 27666, 65242], [33259, 38346, 76450, 27645, 95595, 96640, 59603, 75392, 67938, 45560, 46778, 64568, 83010, 63022, 62581, 88692, 16235, 79857, 2962, 13685, 3437, 79320, 20736, 29024, 58667, 89594, 3785, 60722, 45325, 92773, 48205, 4752, 96939, 84919, 94488, 37204, 98804, 97933, 46695, 94917, 51223, 21804], [15417, 34981, 70860, 41379, 49701, 19114, 40683, 91105, 48605, 56313, 27484, 42341, 20451, 3486, 11674, 48341, 98095, 31557, 22077, 74672, 24310, 10670, 93837, 20072, 91487, 64292, 49198, 5144, 92845, 48220, 86913, 27534, 85742, 1933, 4342, 57306, 74143, 85220, 80063, 51863, 90702, 49045], [39446, 61440, 72294, 34438, 26266, 33809, 25520, 17632, 89951, 59822, 15416, 60381, 75492, 35264, 97658, 57970, 79802, 10186, 18469, 51223, 73589, 4247, 9909, 32509, 99307, 7464, 34554, 50811, 89380, 16242, 37821, 45209, 78140, 90015, 95055, 73738, 66804, 28505, 22836, 41007, 93196, 48795], [75614, 75541, 11309, 54659, 62362, 16206, 89792, 67180, 91389, 79998, 98766, 90164, 25754, 29484, 95313, 16462, 74954, 27641, 92699, 20827, 55902, 75534, 53159, 93555, 83000, 50760, 82866, 10058, 95813, 63650, 38443, 513, 4816, 44908, 51809, 62897, 52366, 80615, 21818, 69692, 48582, 32408], [29899, 10228, 65402, 39878, 58067, 60732, 77658, 51713, 51435, 22785, 80011, 24370, 26257, 67431, 92312, 72064, 99525, 90901, 41443, 42555, 80059, 56365, 15490, 47202, 51639, 77617, 83115, 17765, 1508, 1113, 34721, 26883, 60722, 79407, 95618, 90725, 4113, 75853, 21638, 42625, 86680, 31165], [92179, 23065, 16377, 57752, 16348, 729, 71543, 3853, 40940, 56131, 43923, 80390, 8961, 37509, 45686, 83248, 5608, 6366, 88509, 29379, 51630, 4388, 40955, 44634, 61071, 80717, 73269, 86490, 38986, 86429, 80241, 14805, 69447, 66355, 27803, 58155, 34428, 5231, 44113, 32610, 46778, 8750]]));
