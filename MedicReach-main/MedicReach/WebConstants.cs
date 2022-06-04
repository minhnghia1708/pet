namespace MedicReach
{
    public class WebConstants
    {
        public const string PatientRoleName = "Patient";
        public const string PhysicianRoleName = "Physician";

        public const string GlobalSuccessMessageKey = "GlobalSuccessMessage";
        public const string GlobalErrorMessageKey = "GlobalErrorMessage";

        public const string UserRegistrationSuccessMessage = "Đăng kí thành công. Sử dụng nút 'Become' để hoàn thành hồ sơ của bạn.";

        public const string BecomePhysicianSuccessMessage = "Hồ sơ bác sĩ đã được tạo thành công và đang chờ phê duyệt. Đăng nhập lại nếu bạn muốn chỉnh sửa nó. ";
        public const string BecomePatientSuccessMessage = "Hồ sơ bệnh nhân đã được tạo thành công. Vui lòng đăng nhập lại.";

        public const string EditPhysicianSuccessMessage = "Hồ sơ bác sĩ đã được chỉnh sửa thành công và đang chờ phê duyệt ";
        public const string AdminEditPhysicianSuccessMessage = "Bác sĩ được cập nhật thành công !";
        public const string EditPatientSuccessMessage = "Hồ sơ được cập nhật thành công !";

        public const string AlreadyCreatorOfMedicalCenter = "You're already a creator of a Medical Center. Please, edit it's information instead.";

        public const string CreateMedicalCenterSuccessMessage = "Cơ sở '{0}' đã được tạo thành công !";
        public const string EditMedicalCenterSuccessMessage = "Cơ sở '{0}' đã được cập nhật thành công !";
        public const string EditMedicalCenterErrorMessage = "Medical Center can be edited only by it's creator.";
        public const string CreateMedicalCenterCityAndCountryDontMatchMessage = "City does not match the Country.";

        public const string BookAppointmentSuccessMessage = "Đặt lịch thành công !";
        public const string AppointmentNotAvailableMessage = "Khung giờ {0} : {1} hiện tại không có sẵn. Xin vui lòng chọn ngày giờ khác !";

        public const string AddSpecialitySuccessMessage = "Chuyên môn '{0}' đã được thêm vào thành công !";
        public const string AddMedicalCenterTypeSuccessMessage = "Cơ sở '{0}' đã được thêm vào thành công !";
        public const string AddCountrySuccessMessage = "Quốc gia '{0}, {1}' đã được thêm vào thành công !";
        public const string AddCitySuccessMessage = "Thành phố '{0}' đã được thêm vào thành công !.";

        public const string WriteReviewSuccessMessage = "Bài đánh giá đã được cập nhật !";
    }
}
