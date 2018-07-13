Imports System.Data.Entity
Imports Microsoft.AspNet.Identity.EntityFramework



Public Class ApplicationDbContext

    Inherits IdentityDbContext(Of ApplicationUser)

    Public Sub New()
        MyBase.New("DefaultConnection")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        MyBase.OnModelCreating(modelBuilder)
        modelBuilder.Configurations.Add(New CertificationCfg())
        modelBuilder.Configurations.Add(New CommentaireCfg())
        modelBuilder.Configurations.Add(New CompetenceCfg())
        modelBuilder.Configurations.Add(New CompteBancaireCfg())
        modelBuilder.Configurations.Add(New ConsulterCvCfg())
        modelBuilder.Configurations.Add(New CursusCfg())
        modelBuilder.Configurations.Add(New CvCfg())
        modelBuilder.Configurations.Add(New DiversCfg())
        modelBuilder.Configurations.Add(New JobsCfg())
        modelBuilder.Configurations.Add(New JobsNotificationCfg())
        modelBuilder.Configurations.Add(New MessagerieCfg())
        modelBuilder.Configurations.Add(New NoterJobCfg())
        modelBuilder.Configurations.Add(New NotificationCfg())
        modelBuilder.Configurations.Add(New PaysCfg())
        modelBuilder.Configurations.Add(New PersonneDeReferenceCfg())
        modelBuilder.Configurations.Add(New PieceJointeCfg())
        modelBuilder.Configurations.Add(New PostulerJobCfg())
        modelBuilder.Configurations.Add(New ReferenceCfg())
        modelBuilder.Configurations.Add(New SecteurActiviteCfg())
        modelBuilder.Configurations.Add(New ServiceCfg())
        modelBuilder.Configurations.Add(New SousSecteurActiviteCfg())
        modelBuilder.Configurations.Add(New StatutCfg())
        modelBuilder.Configurations.Add(New TypeCompteCfg())
        modelBuilder.Configurations.Add(New TypeCursusCfg())
        modelBuilder.Configurations.Add(New TypeJobCfg())
        modelBuilder.Configurations.Add(New TypeMessagerieCfg())
        modelBuilder.Configurations.Add(New UserSousSecteurActiviteCfg())
    End Sub

    Public Property Certification() As DbSet(Of Certification)
    Public Property Commentaire() As DbSet(Of Commentaire)
    Public Property Competence() As DbSet(Of Competence)
    Public Property CompteBancaire() As DbSet(Of CompteBancaire)
    Public Property Consulter() As DbSet(Of ConsulterCv)
    Public Property Cursus() As DbSet(Of Cursus)
    Public Property Cv() As DbSet(Of Cv)
    Public Property Divers() As DbSet(Of Divers)
    Public Property Jobs() As DbSet(Of Jobs)
    Public Property JobsNotification() As DbSet(Of JobsNotification)
    Public Property Messagerie() As DbSet(Of Messagerie)
    Public Property Notification() As DbSet(Of Notification)
    Public Property NoterJob() As DbSet(Of NoterJob)
    Public Property Pays() As DbSet(Of Pays)
    Public Property PersonneDeReference() As DbSet(Of PersonneDeReference)
    Public Property PieceJointe() As DbSet(Of PieceJointe)
    Public Property Postuler() As DbSet(Of PostulerJob)
    Public Property Reference() As DbSet(Of Reference)
    Public Property SecteurActivite() As DbSet(Of SecteurActivite)
    Public Property Service() As DbSet(Of Service)
    Public Property SousSecteurActivite() As DbSet(Of SousSecteurActivite)
    Public Property Statuts() As DbSet(Of Statut)
    Public Property TypeCompte() As DbSet(Of TypeCompte)
    Public Property TypeCursus() As DbSet(Of TypeCursus)
    Public Property TypeJob() As DbSet(Of TypeJob)
    Public Property TypeMessagerie() As DbSet(Of TypeMessagerie)
    Public Property UserSousSecteur() As DbSet(Of UserSousSecteurActivite)

    'Ils sont commentes a cause de la redondance que EntityFramework essaye de resoudre.
    'Donc chaque fois qu'on genere un nouveau controller il faudra regarder les lignes ci-dessous.

    'Public Property IdentityUsers As System.Data.Entity.DbSet(Of ApplicationUser)    
    'Public Property IdentityUsers As System.Data.Entity.DbSet(Of ApplicationUser)
    'Public Property IdentityUsers As System.Data.Entity.DbSet(Of ApplicationUser)
    'Public Property IdentityUsers As System.Data.Entity.DbSet(Of ApplicationUser)
    'Public Property IdentityUsers As System.Data.Entity.DbSet(Of ApplicationUser)
    'Public Property IdentityUsers As System.Data.Entity.DbSet(Of ApplicationUser)
    'Public Property IdentityUsers As System.Data.Entity.DbSet(Of ApplicationUser)


End Class
