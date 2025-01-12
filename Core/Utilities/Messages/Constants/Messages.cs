

namespace Core.Utilities.Messages.Constants
{
    public static class Messages
    {
        #region Messages Of Car

        #region Car Messages For Successful Processes

                public const string CarAddedSuccessfully = "Araba Başarıyla Eklendi.";
                public const string CarUpdatedSuccessfully = "Araba Başarıyla Güncellendi.";
                public const string CarDeletedSuccessfully = "Araba Başarıyla Silindi";
                public const string CarsListedSuccessfully = "Arabalar Başarıyla Listelendi";
        #endregion


        #region ValidationMessages
        public const string CarNameMustBeNotNull = "Araba Açıklama Bilgisi Boş Geçilemez";
        public const string ColorNameMustBeNotNullOnTheCarDefinition = "Araba Tanımlama Esnasında Renk Bilgisi Boş Geçilemez.";
        public const string IsOkayNotBeNullOnTheCarDefinition = "Araba Tanımlama Esnasında Aracın Müsaitlik bilgisi Boş Geçilemez.";
        public const string DailyPriceNotBeNullOnTheCartDefinition = "Araba tanımlama esnasında Günlük Fiyat Bilgisi Boş Geçilemez.";

        #endregion


        #region Car Messages For Failed Process
                public const string CarAddedError = "Araba Eklenirken Hata!";
                public const string CarpdatedError = "Araba Güncellenirken Hata!";
                public const string CarDeletedError = "Araba Silinirken Hata!";
                public const string CarsListedError = "Arabalar Listelenirken Hata!";
        #endregion

        #endregion


        #region Messages Of Color

        #region Color Messages For Successful Process

            public const string ColorAddedSuccessfully = "Renk Başarıyla Eklendi.";
            public const string ColorUpdatedSuccessfully = "Renk Başarıyla Güncellendi.";
            public const string ColorDeletedSuccessfully = "Renk Başarıyla Silindi";
            public const string ColorsListedSuccessfully = "Renkler Başarıyla Listelendi";
      
        #endregion

        #region Color Messages For Failed Process

            public const string ColorAddedError = "Renk Eklenirken Hata!";
            public const string ColorUpdatedError = "Renk Güncellenirken Hata!";
            public const string ColorDeletedError = "Renk Silinirken Hata!";
            public const string ColorsListedError = "Renkler Listelenirken Hata!";

        #endregion

        #endregion


        #region Messages Of Brand

        #region Brand Messages For Successful Process

            public const string BrandAddedSuccessfully = "Marka Başarıyla Eklendi.";
            public const string BrandUpdatedSuccessfully = "Marka Başarıyla Güncellendi.";
            public const string BrandDeletedSuccessfully = "Marka Başarıyla Silindi";
            public const string BrandsListedSuccessfully = "Markalar Başarıyla Listelendi.";

        #endregion

        #region Brand Messages For Failed Process

            public const string BrandAddError = "Marka Eklenirken Hata!";
            public const string BrandUpdateError = "Marka Güncellenirken Hata!";
            public const string BrandDeleteError = "Marka Silinirken Hata!";
            public const string BrandsListedError = "Markalar Listelenirken Hata!";

        #endregion

        #endregion


        #region Global Messages

            public const string MaintenanceTimeError = "Sistem Saat 22.00 İtibariyle Bakıma Alındığı İçin Hizmet Verememektedir. Lütfen Bir Kaç Saat Sonra Tekrar Deneyiniz.";

        #endregion

    }
}
