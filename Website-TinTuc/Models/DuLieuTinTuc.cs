using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Website_TinTuc.Models
{
    public class DuLieuTinTuc : DropCreateDatabaseAlways<DinhNghiaTinTuc>
    {
        protected override void Seed(DinhNghiaTinTuc context)
        {
            GetTacgias().ForEach(c => context.Tacgias.Add(c));
            GetTinTucs().ForEach(p => context.Tintucs.Add(p));
        }
        private static List<TacGia> GetTacgias()
        {
            var categories = new List<TacGia> {
                new TacGia
               {
                 TGia_ID = 1,
                 TenTG = "vnexpress",
                 Email = "vnexpress@email.com"
                 },
                 new TacGia
                 {
                 TGia_ID = 2,
                 TenTG = "vietnammoi",
                 Email = "vietnammoiegmail.com"
                 },
                 new TacGia{
                 TGia_ID= 3,
                 TenTG = "dantri",
                 Email = "dantri@email.com"
                 },
                 new TacGia{
                 TGia_ID= 4,
                 TenTG = "24h",
                 Email = "24h@email.com"
                 },
                 };
            return categories;
        }
        private static List<TinTuc> GetTinTucs()
        {
            var books = new List<TinTuc> {

                 new TinTuc
                 {
                 Tin_ID = 1,
                 NoiDung = "NGHỆ ANNguyễn Thị Doan (47 tuổi, trú huyện Đô Lương) bị tạm giữ với cáo buộc đã ném chăn, cầm chân dốc ngược, cư xử thô bạo với bé Trâm Anh 14 tháng tuổi."

 + "Ngày 9/12, bà Doan bị Công an thành phố Vinh (Nghệ An) điều tra về hành vi Hành hạ người khác, điều 140, Bộ luật Hình sự 2015" +

"Bà Doan nói hối hận những gì đã gây ra với nạn nhân, khai do bức xúc nhất thời nên làm vậy, cán bộ công an cho biết. Trước khi bị tạm giữ, trả lời VnExpress, " +
"bà Doan kể tối 4/12 cho Trâm Anh bú bình xong thì đưa lên giường ru ngủ như thường lệ nhưng bé bị trớ, liên tục khóc. Tôi lau chùi sạch sẽ để bé ngủ nhưng không có kết quả nên cầm chăn úp lên người rồi túm chân dốc ngược. " +
"Tất cả chỉ nhằm mục đích cho ngủ. Giờ tôi biết mình đã sai và rất muốn được gia đình bé tha thứ... bà Doan nói và cho biết do đông con cháu nên rất hiểu công việc chăm sóc trẻ Trước đó, vợ chồng chị Phạm Thị Thu Hường ở thành phố Vinh xem lại dữ liệu camera an ninh thì phát hiện đêm 4/12 trong lúc vợ chồng chị vắng nhà hơn một giờ, người giúp việc là bà Doan đã nhiều lần cầm chân bé Trâm Anh dốc ngược, " +
"ném chăn vào người, mặc cho đứa trẻ khóc thét. Hành động này kéo dài khoảng 4 phút. Cho rằng cần phải lên tiếng để bảo vệ con gái và khuyến cáo để các gia đình khác không thuê trúng người giúp việc như bà Doan, vợ chồng chị đã trình báo công an. Bà Doan mới làm giúp việc cho gia đình chị Hường được gần một tháng với tiền công 4,5 triệu đồng một tháng.",
                 NgayGui = "9/12/2019",
                 HinhAnh ="",
                 TGia_ID = 1
                 },

                 new TinTuc
                 {
                 Tin_ID = 2,
                 NoiDung = "BÀ RỊA - VŨNG TÀUPhạm Tiến Vĩnh, 34 tuổi, nhờ hai côn đồ đến chém chết người sau khi xảy ra đánh nhau với hàng xóm vì nước rửa cá văng trúng xe máy.Phạm Tiến Vĩnh," +
                 " Đỗ Minh Tài (34 tuổi) và Văn Huỳnh Bảo Kha (28 tuổi, cùng ở huyện Long Điền) bị Công an Bà Rịa - Vũng Tàu bắt giữ để điều tra hành vi Giết người. Ngoài ra, nhiều người liên quan " +
                 "cũng bị mời lên làm việc.Diễn biến sự việc bước đầu được xác định, chiều 7/9, vợ ông Nguyễn Hùng (44 tuổi, ở thị trấn Phước Hải) tạt nước rửa cá ra con hẻm trước nhà trúng xe máy " +
                 "Phạm Tiến Vĩnh - là hàng xóm. Hai bên cãi vã, lao vào đánh nhau. Được mọi người can ngăn, Vĩnh về nhà và sau đó gọi Tài, Kha đến trả thù. Hai côn đồ đuổi chém chết ông Hùng với bảy" +
                 " nhát dao. Sau đó, cả ba bỏ trốn.",
                 NgayGui = "1/12/2019",
                 HinhAnh ="",
                 TGia_ID = 2
                 },

                 new TinTuc
                 {
                 Tin_ID = 3,
                 NoiDung = "BẮC NINHNgô Bá Khá (26 tuổi, Khá Bảnh) gửi đơn kháng cáo đến TAND thị xã Từ Sơn xin giảm nhẹ hình phạt về mức án hơn 10 năm tù. Khá không kêu oan, chỉ kháng cáo xin " +
                 "giảm nhẹ hình phạt 4 năm tù về tội Đánh bạc, 6 năm 6 tháng tù do Tổ chức đánh bạc, lãnh đạo TAND thị xã Từ Sơn cho biết, chiều 9/12. Bốn đồng phạm còn lại cũng kháng cáo " +
                 "xin giảm nhẹ hình phạt.",
                 NgayGui = "4/4/2019",
                 HinhAnh ="",
                 TGia_ID = 3
                 },
                 new TinTuc
                 {
                 Tin_ID = 4,
                 NoiDung = "TRUNG QUỐCTrong phòng trọ 303 xảy ra hỏa hoạn, dưới đống quần áo, chăn ga cháy khét có thi thể của hai phụ nữ. Khám nghiệm hiện trường ngay hôm đó, 3/9/2015, Cảnh sát huyện Tảo Cường," +
                 " tỉnh Hà Bắc, Trung Quốc nhận ra một trong hai nạn nhân là khách thuê trọ, tên Trương Liệu (21 tuổi). Người còn lại không biết là ai. Cửa sổ phòng 303 có dấu hiệu bị cậy phá, trên lớp bụi bên ngoài " +
                 "cửa sổ có dấu giày lạ của đàn ông. Trong phòng có một giường đôi và một giường đơn. Chủ nhà trọ cho biết, Liệu sống cùng nữ đồng nghiệp tên Linh. Sàn nhà đã được lau qua nhưng vẫn có thể thấy dưới" +
                 " gầm giường đôi có vết máu. Trên giường đơn có chiếc điện thoại của Trương Liệu. Đồ đạc có giá trị không bị mất.",
                 NgayGui = "5/12/2019",
                 HinhAnh ="",
                 TGia_ID = 4
                 },
                 };
            return books;
        }
    }
}