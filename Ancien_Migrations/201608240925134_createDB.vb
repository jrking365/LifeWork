Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Partial Public Class createDB
        Inherits DbMigration

        Public Overrides Sub Up()
            CreateTable(
                "dbo.Certification",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .CvId = c.Long(nullable:=False),
                        .Libelle = c.String(nullable:=False, maxLength:=500),
                        .Description = c.String(),
                        .DateObtention = c.DateTime(),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Cv", Function(t) t.CvId, cascadeDelete:=True) _
                .Index(Function(t) t.CvId)

            CreateTable(
                "dbo.Cv",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .UserId = c.String(maxLength:=128),
                        .Titre = c.String(nullable:=False, maxLength:=500),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserId) _
                .Index(Function(t) t.UserId)

            CreateTable(
                "dbo.AspNetUsers",
                Function(c) New With
                    {
                        .Id = c.String(nullable:=False, maxLength:=128),
                        .UserName = c.String(),
                        .PasswordHash = c.String(),
                        .SecurityStamp = c.String(),
                        .PaysId = c.Long(),
                        .TypeCompteId = c.Long(),
                        .Nom = c.String(),
                        .Prenom = c.String(),
                        .NumeroCompte = c.String(),
                        .DateNaissance = c.DateTime(),
                        .Sexe = c.String(),
                        .Email = c.String(),
                        .Telephone = c.String(),
                        .Cni = c.String(),
                        .Fonction = c.String(),
                        .Entreprise = c.String(),
                        .SiteWeb = c.String(),
                        .Photo = c.Binary(),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime(),
                        .Discriminator = c.String(nullable:=False, maxLength:=128)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Pays", Function(t) t.PaysId, cascadeDelete:=True) _
                .ForeignKey("dbo.TypeCompte", Function(t) t.TypeCompteId, cascadeDelete:=True) _
                .Index(Function(t) t.PaysId) _
                .Index(Function(t) t.TypeCompteId)

            CreateTable(
                "dbo.AspNetUserClaims",
                Function(c) New With
                    {
                        .Id = c.Int(nullable:=False, identity:=True),
                        .ClaimType = c.String(),
                        .ClaimValue = c.String(),
                        .User_Id = c.String(nullable:=False, maxLength:=128)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.User_Id, cascadeDelete:=True) _
                .Index(Function(t) t.User_Id)

            CreateTable(
                "dbo.AspNetUserLogins",
                Function(c) New With
                    {
                        .UserId = c.String(nullable:=False, maxLength:=128),
                        .LoginProvider = c.String(nullable:=False, maxLength:=128),
                        .ProviderKey = c.String(nullable:=False, maxLength:=128)
                    }) _
                .PrimaryKey(Function(t) New With {t.UserId, t.LoginProvider, t.ProviderKey}) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserId, cascadeDelete:=True) _
                .Index(Function(t) t.UserId)

            CreateTable(
                "dbo.AspNetUserRoles",
                Function(c) New With
                    {
                        .UserId = c.String(nullable:=False, maxLength:=128),
                        .RoleId = c.String(nullable:=False, maxLength:=128)
                    }) _
                .PrimaryKey(Function(t) New With {t.UserId, t.RoleId}) _
                .ForeignKey("dbo.AspNetRoles", Function(t) t.RoleId, cascadeDelete:=True) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserId, cascadeDelete:=True) _
                .Index(Function(t) t.RoleId) _
                .Index(Function(t) t.UserId)

            CreateTable(
                "dbo.AspNetRoles",
                Function(c) New With
                    {
                        .Id = c.String(nullable:=False, maxLength:=128),
                        .Name = c.String(nullable:=False)
                    }) _
                .PrimaryKey(Function(t) t.Id)

            CreateTable(
                "dbo.Jobs",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .UserPublierId = c.Long(nullable:=False),
                        .UserAttribuerId = c.Long(nullable:=False),
                        .TypeJobId = c.Long(nullable:=False),
                        .SousSecteurActiviteId = c.Long(nullable:=False),
                        .StatutId = c.Long(nullable:=False),
                        .Titre = c.String(nullable:=False, maxLength:=500),
                        .Duree = c.String(),
                        .Code = c.String(),
                        .Description = c.String(nullable:=False, maxLength:=500),
                        .LieuExecution = c.String(),
                        .DatePrevueLivraison = c.DateTime(nullable:=False),
                        .DatePublication = c.DateTime(),
                        .DateAttribution = c.DateTime(),
                        .DateCloture = c.DateTime(),
                        .BudgetMinimal = c.Decimal(precision:=18, scale:=2),
                        .BudgetMaximal = c.Decimal(precision:=18, scale:=2),
                        .BudgetAttribution = c.String(),
                        .CahierDeCharge = c.Binary(),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime(),
                        .UserAttribuer_Id = c.String(maxLength:=128),
                        .UserPublier_Id = c.String(maxLength:=128),
                        .ApplicationUser_Id = c.String(maxLength:=128),
                        .ApplicationUser_Id1 = c.String(maxLength:=128),
                        .ApplicationUser_Id2 = c.String(maxLength:=128)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.SousSecteurActivite", Function(t) t.SousSecteurActiviteId, cascadeDelete:=True) _
                .ForeignKey("dbo.Statut", Function(t) t.StatutId, cascadeDelete:=True) _
                .ForeignKey("dbo.TypeJob", Function(t) t.TypeJobId, cascadeDelete:=True) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserAttribuer_Id) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserPublier_Id) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.ApplicationUser_Id) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.ApplicationUser_Id1) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.ApplicationUser_Id2) _
                .Index(Function(t) t.SousSecteurActiviteId) _
                .Index(Function(t) t.StatutId) _
                .Index(Function(t) t.TypeJobId) _
                .Index(Function(t) t.UserAttribuer_Id) _
                .Index(Function(t) t.UserPublier_Id) _
                .Index(Function(t) t.ApplicationUser_Id) _
                .Index(Function(t) t.ApplicationUser_Id1) _
                .Index(Function(t) t.ApplicationUser_Id2)

            CreateTable(
                "dbo.SousSecteurActivite",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .SecteurActiviteId = c.Long(nullable:=False),
                        .Libelle = c.String(nullable:=False, maxLength:=500),
                        .Description = c.String(),
                        .Code = c.String(),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.SecteurActivite", Function(t) t.SecteurActiviteId, cascadeDelete:=True) _
                .Index(Function(t) t.SecteurActiviteId)

            CreateTable(
                "dbo.SecteurActivite",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .Libelle = c.String(nullable:=False, maxLength:=500),
                        .Description = c.String(),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id)

            CreateTable(
                "dbo.Service",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .UserId = c.String(maxLength:=128),
                        .SousSecteurActiviteId = c.Long(nullable:=False),
                        .Titre = c.String(nullable:=False, maxLength:=500),
                        .Description = c.String(),
                        .DatePostulation = c.DateTime(),
                        .DureeRealisation = c.String(),
                        .MontantMinimal = c.Decimal(precision:=18, scale:=2),
                        .MontantMaximal = c.Decimal(precision:=18, scale:=2),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.SousSecteurActivite", Function(t) t.SousSecteurActiviteId, cascadeDelete:=True) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserId) _
                .Index(Function(t) t.SousSecteurActiviteId) _
                .Index(Function(t) t.UserId)

            CreateTable(
                "dbo.Statut",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .Libelle = c.String(nullable:=False, maxLength:=500),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id)

            CreateTable(
                "dbo.TypeJob",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .Libelle = c.String(nullable:=False, maxLength:=500),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id)

            CreateTable(
                "dbo.Pays",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .Nom = c.String(nullable:=False, maxLength:=500),
                        .Abreviation = c.String(),
                        .IdentifiantTelephonique = c.String(),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id)

            CreateTable(
                "dbo.TypeCompte",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .Libelle = c.String(nullable:=False, maxLength:=500),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id)

            CreateTable(
                "dbo.Commentaire",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .JobsId = c.Long(nullable:=False),
                        .UserEmployeurId = c.String(maxLength:=128),
                        .UserPrestataireId = c.String(maxLength:=128),
                        .Contenu = c.String(nullable:=False, maxLength:=500),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime(nullable:=False)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Jobs", Function(t) t.JobsId, cascadeDelete:=True) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserEmployeurId) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserPrestataireId) _
                .Index(Function(t) t.JobsId) _
                .Index(Function(t) t.UserEmployeurId) _
                .Index(Function(t) t.UserPrestataireId)

            CreateTable(
                "dbo.Competence",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .CvId = c.Long(nullable:=False),
                        .Libelle = c.String(nullable:=False, maxLength:=500),
                        .Description = c.String(),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime(nullable:=False)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Cv", Function(t) t.CvId, cascadeDelete:=True) _
                .Index(Function(t) t.CvId)

            CreateTable(
                "dbo.CompteBancaire",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .UserId = c.String(maxLength:=128),
                        .Code = c.String(nullable:=False, maxLength:=500),
                        .DatePeremption = c.DateTime(),
                        .Solde = c.Decimal(precision:=18, scale:=2),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserId) _
                .Index(Function(t) t.UserId)

            CreateTable(
                "dbo.ConsulterCv",
                Function(c) New With
                    {
                        .CvId = c.Long(nullable:=False),
                        .UserId = c.String(nullable:=False, maxLength:=128),
                        .DateConsulter = c.DateTime(nullable:=False)
                    }) _
                .PrimaryKey(Function(t) New With {t.CvId, t.UserId}) _
                .ForeignKey("dbo.Cv", Function(t) t.CvId, cascadeDelete:=True) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserId, cascadeDelete:=True) _
                .Index(Function(t) t.CvId) _
                .Index(Function(t) t.UserId)

            CreateTable(
                "dbo.Cursus",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .TypeCursusId = c.Long(nullable:=False),
                        .CvId = c.Long(nullable:=False),
                        .Titre = c.String(),
                        .Poste = c.String(),
                        .Structures = c.String(nullable:=False, maxLength:=500),
                        .Diplome = c.String(nullable:=False, maxLength:=500),
                        .Periode = c.String(),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Cv", Function(t) t.CvId, cascadeDelete:=True) _
                .ForeignKey("dbo.TypeCursus", Function(t) t.TypeCursusId, cascadeDelete:=True) _
                .Index(Function(t) t.CvId) _
                .Index(Function(t) t.TypeCursusId)

            CreateTable(
                "dbo.TypeCursus",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .Type = c.String(nullable:=False, maxLength:=500),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id)

            CreateTable(
                "dbo.Divers",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .CvId = c.Long(nullable:=False),
                        .Titre = c.String(nullable:=False, maxLength:=500),
                        .Commentaire = c.String(),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Cv", Function(t) t.CvId, cascadeDelete:=True) _
                .Index(Function(t) t.CvId)

            CreateTable(
                "dbo.JobsNotification",
                Function(c) New With
                    {
                        .JobsId = c.Long(nullable:=False),
                        .NotificationId = c.Long(nullable:=False),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) New With {t.JobsId, t.NotificationId}) _
                .ForeignKey("dbo.Jobs", Function(t) t.JobsId, cascadeDelete:=True) _
                .ForeignKey("dbo.Notification", Function(t) t.NotificationId, cascadeDelete:=True) _
                .Index(Function(t) t.JobsId) _
                .Index(Function(t) t.NotificationId)

            CreateTable(
                "dbo.Notification",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .Titre = c.String(nullable:=False, maxLength:=500),
                        .Contenu = c.String(),
                        .DateEnvoi = c.DateTime(),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id)

            CreateTable(
                "dbo.Messagerie",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .TypeMessagerieId = c.Long(nullable:=False),
                        .UserExpediteurId = c.String(maxLength:=128),
                        .UserDestinataireId = c.String(maxLength:=128),
                        .JobsId = c.Long(nullable:=False),
                        .Contenu = c.String(nullable:=False, maxLength:=500),
                        .Objet = c.String(nullable:=False, maxLength:=500),
                        .DateEnvoi = c.DateTime(nullable:=False),
                        .DateReception = c.DateTime(nullable:=False),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.TypeMessagerie", Function(t) t.TypeMessagerieId, cascadeDelete:=True) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserDestinataireId) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserExpediteurId) _
                .Index(Function(t) t.TypeMessagerieId) _
                .Index(Function(t) t.UserDestinataireId) _
                .Index(Function(t) t.UserExpediteurId)

            CreateTable(
                "dbo.PieceJointe",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .MessagerieId = c.Long(nullable:=False),
                        .Piece = c.Binary(),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Messagerie", Function(t) t.MessagerieId, cascadeDelete:=True) _
                .Index(Function(t) t.MessagerieId)

            CreateTable(
                "dbo.TypeMessagerie",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .Titre = c.String(nullable:=False, maxLength:=500),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id)

            CreateTable(
                "dbo.NoterJob",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .UserEmployeurId = c.String(maxLength:=128),
                        .UserPrestataireId = c.String(maxLength:=128),
                        .JobsId = c.Long(nullable:=False),
                        .NoteEmployeur = c.Decimal(precision:=18, scale:=2),
                        .NotePrestataire = c.Decimal(precision:=18, scale:=2),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime(nullable:=False)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Jobs", Function(t) t.JobsId, cascadeDelete:=True) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserEmployeurId) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserPrestataireId) _
                .Index(Function(t) t.JobsId) _
                .Index(Function(t) t.UserEmployeurId) _
                .Index(Function(t) t.UserPrestataireId)

            CreateTable(
                "dbo.PersonneDeReference",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .CvId = c.Long(nullable:=False),
                        .Nom = c.String(nullable:=False, maxLength:=500),
                        .Prenom = c.String(),
                        .Sexe = c.String(),
                        .Telephone = c.String(),
                        .Profession = c.String(nullable:=False, maxLength:=500),
                        .Email = c.String(),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Cv", Function(t) t.CvId, cascadeDelete:=True) _
                .Index(Function(t) t.CvId)

            CreateTable(
                "dbo.PostulerJob",
                Function(c) New With
                    {
                        .UserId = c.String(nullable:=False, maxLength:=128),
                        .JobsId = c.Long(nullable:=False),
                        .Description = c.String(nullable:=False, maxLength:=500),
                        .DureeExecution = c.String(),
                        .BudgetExige = c.Decimal(precision:=18, scale:=2),
                        .DateEnvoi = c.DateTime(nullable:=False),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) New With {t.UserId, t.JobsId}) _
                .ForeignKey("dbo.Jobs", Function(t) t.JobsId, cascadeDelete:=True) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserId, cascadeDelete:=True) _
                .Index(Function(t) t.JobsId) _
                .Index(Function(t) t.UserId)

            CreateTable(
                "dbo.Reference",
                Function(c) New With
                    {
                        .Id = c.Long(nullable:=False, identity:=True),
                        .Titre = c.String(nullable:=False, maxLength:=500),
                        .Description = c.String(),
                        .Adresse = c.String(),
                        .Annee = c.DateTime(),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime(),
                        .cv_Id = c.Long()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Cv", Function(t) t.cv_Id) _
                .Index(Function(t) t.cv_Id)

            CreateTable(
                "dbo.UserSousSecteurActivite",
                Function(c) New With
                    {
                        .UserId = c.String(nullable:=False, maxLength:=128),
                        .SousSecteurActiviteId = c.Long(nullable:=False),
                        .StatutExistant = c.Boolean(),
                        .DateCreation = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) New With {t.UserId, t.SousSecteurActiviteId}) _
                .ForeignKey("dbo.SousSecteurActivite", Function(t) t.SousSecteurActiviteId, cascadeDelete:=True) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserId, cascadeDelete:=True) _
                .Index(Function(t) t.SousSecteurActiviteId) _
                .Index(Function(t) t.UserId)

        End Sub

        Public Overrides Sub Down()
            DropForeignKey("dbo.UserSousSecteurActivite", "UserId", "dbo.AspNetUsers")
            DropForeignKey("dbo.UserSousSecteurActivite", "SousSecteurActiviteId", "dbo.SousSecteurActivite")
            DropForeignKey("dbo.Reference", "cv_Id", "dbo.Cv")
            DropForeignKey("dbo.PostulerJob", "UserId", "dbo.AspNetUsers")
            DropForeignKey("dbo.PostulerJob", "JobsId", "dbo.Jobs")
            DropForeignKey("dbo.PersonneDeReference", "CvId", "dbo.Cv")
            DropForeignKey("dbo.NoterJob", "UserPrestataireId", "dbo.AspNetUsers")
            DropForeignKey("dbo.NoterJob", "UserEmployeurId", "dbo.AspNetUsers")
            DropForeignKey("dbo.NoterJob", "JobsId", "dbo.Jobs")
            DropForeignKey("dbo.Messagerie", "UserExpediteurId", "dbo.AspNetUsers")
            DropForeignKey("dbo.Messagerie", "UserDestinataireId", "dbo.AspNetUsers")
            DropForeignKey("dbo.Messagerie", "TypeMessagerieId", "dbo.TypeMessagerie")
            DropForeignKey("dbo.PieceJointe", "MessagerieId", "dbo.Messagerie")
            DropForeignKey("dbo.JobsNotification", "NotificationId", "dbo.Notification")
            DropForeignKey("dbo.JobsNotification", "JobsId", "dbo.Jobs")
            DropForeignKey("dbo.Divers", "CvId", "dbo.Cv")
            DropForeignKey("dbo.Cursus", "TypeCursusId", "dbo.TypeCursus")
            DropForeignKey("dbo.Cursus", "CvId", "dbo.Cv")
            DropForeignKey("dbo.ConsulterCv", "UserId", "dbo.AspNetUsers")
            DropForeignKey("dbo.ConsulterCv", "CvId", "dbo.Cv")
            DropForeignKey("dbo.CompteBancaire", "UserId", "dbo.AspNetUsers")
            DropForeignKey("dbo.Competence", "CvId", "dbo.Cv")
            DropForeignKey("dbo.Commentaire", "UserPrestataireId", "dbo.AspNetUsers")
            DropForeignKey("dbo.Commentaire", "UserEmployeurId", "dbo.AspNetUsers")
            DropForeignKey("dbo.Commentaire", "JobsId", "dbo.Jobs")
            DropForeignKey("dbo.Certification", "CvId", "dbo.Cv")
            DropForeignKey("dbo.Cv", "UserId", "dbo.AspNetUsers")
            DropForeignKey("dbo.AspNetUsers", "TypeCompteId", "dbo.TypeCompte")
            DropForeignKey("dbo.AspNetUsers", "PaysId", "dbo.Pays")
            DropForeignKey("dbo.Jobs", "ApplicationUser_Id2", "dbo.AspNetUsers")
            DropForeignKey("dbo.Jobs", "ApplicationUser_Id1", "dbo.AspNetUsers")
            DropForeignKey("dbo.Jobs", "ApplicationUser_Id", "dbo.AspNetUsers")
            DropForeignKey("dbo.Jobs", "UserPublier_Id", "dbo.AspNetUsers")
            DropForeignKey("dbo.Jobs", "UserAttribuer_Id", "dbo.AspNetUsers")
            DropForeignKey("dbo.Jobs", "TypeJobId", "dbo.TypeJob")
            DropForeignKey("dbo.Jobs", "StatutId", "dbo.Statut")
            DropForeignKey("dbo.Service", "UserId", "dbo.AspNetUsers")
            DropForeignKey("dbo.Service", "SousSecteurActiviteId", "dbo.SousSecteurActivite")
            DropForeignKey("dbo.SousSecteurActivite", "SecteurActiviteId", "dbo.SecteurActivite")
            DropForeignKey("dbo.Jobs", "SousSecteurActiviteId", "dbo.SousSecteurActivite")
            DropForeignKey("dbo.AspNetUserClaims", "User_Id", "dbo.AspNetUsers")
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers")
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles")
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers")
            DropIndex("dbo.UserSousSecteurActivite", New String() {"UserId"})
            DropIndex("dbo.UserSousSecteurActivite", New String() {"SousSecteurActiviteId"})
            DropIndex("dbo.Reference", New String() {"cv_Id"})
            DropIndex("dbo.PostulerJob", New String() {"UserId"})
            DropIndex("dbo.PostulerJob", New String() {"JobsId"})
            DropIndex("dbo.PersonneDeReference", New String() {"CvId"})
            DropIndex("dbo.NoterJob", New String() {"UserPrestataireId"})
            DropIndex("dbo.NoterJob", New String() {"UserEmployeurId"})
            DropIndex("dbo.NoterJob", New String() {"JobsId"})
            DropIndex("dbo.Messagerie", New String() {"UserExpediteurId"})
            DropIndex("dbo.Messagerie", New String() {"UserDestinataireId"})
            DropIndex("dbo.Messagerie", New String() {"TypeMessagerieId"})
            DropIndex("dbo.PieceJointe", New String() {"MessagerieId"})
            DropIndex("dbo.JobsNotification", New String() {"NotificationId"})
            DropIndex("dbo.JobsNotification", New String() {"JobsId"})
            DropIndex("dbo.Divers", New String() {"CvId"})
            DropIndex("dbo.Cursus", New String() {"TypeCursusId"})
            DropIndex("dbo.Cursus", New String() {"CvId"})
            DropIndex("dbo.ConsulterCv", New String() {"UserId"})
            DropIndex("dbo.ConsulterCv", New String() {"CvId"})
            DropIndex("dbo.CompteBancaire", New String() {"UserId"})
            DropIndex("dbo.Competence", New String() {"CvId"})
            DropIndex("dbo.Commentaire", New String() {"UserPrestataireId"})
            DropIndex("dbo.Commentaire", New String() {"UserEmployeurId"})
            DropIndex("dbo.Commentaire", New String() {"JobsId"})
            DropIndex("dbo.Certification", New String() {"CvId"})
            DropIndex("dbo.Cv", New String() {"UserId"})
            DropIndex("dbo.AspNetUsers", New String() {"TypeCompteId"})
            DropIndex("dbo.AspNetUsers", New String() {"PaysId"})
            DropIndex("dbo.Jobs", New String() {"ApplicationUser_Id2"})
            DropIndex("dbo.Jobs", New String() {"ApplicationUser_Id1"})
            DropIndex("dbo.Jobs", New String() {"ApplicationUser_Id"})
            DropIndex("dbo.Jobs", New String() {"UserPublier_Id"})
            DropIndex("dbo.Jobs", New String() {"UserAttribuer_Id"})
            DropIndex("dbo.Jobs", New String() {"TypeJobId"})
            DropIndex("dbo.Jobs", New String() {"StatutId"})
            DropIndex("dbo.Service", New String() {"UserId"})
            DropIndex("dbo.Service", New String() {"SousSecteurActiviteId"})
            DropIndex("dbo.SousSecteurActivite", New String() {"SecteurActiviteId"})
            DropIndex("dbo.Jobs", New String() {"SousSecteurActiviteId"})
            DropIndex("dbo.AspNetUserClaims", New String() {"User_Id"})
            DropIndex("dbo.AspNetUserRoles", New String() {"UserId"})
            DropIndex("dbo.AspNetUserRoles", New String() {"RoleId"})
            DropIndex("dbo.AspNetUserLogins", New String() {"UserId"})
            DropTable("dbo.UserSousSecteurActivite")
            DropTable("dbo.Reference")
            DropTable("dbo.PostulerJob")
            DropTable("dbo.PersonneDeReference")
            DropTable("dbo.NoterJob")
            DropTable("dbo.TypeMessagerie")
            DropTable("dbo.PieceJointe")
            DropTable("dbo.Messagerie")
            DropTable("dbo.Notification")
            DropTable("dbo.JobsNotification")
            DropTable("dbo.Divers")
            DropTable("dbo.TypeCursus")
            DropTable("dbo.Cursus")
            DropTable("dbo.ConsulterCv")
            DropTable("dbo.CompteBancaire")
            DropTable("dbo.Competence")
            DropTable("dbo.Commentaire")
            DropTable("dbo.TypeCompte")
            DropTable("dbo.Pays")
            DropTable("dbo.TypeJob")
            DropTable("dbo.Statut")
            DropTable("dbo.Service")
            DropTable("dbo.SecteurActivite")
            DropTable("dbo.SousSecteurActivite")
            DropTable("dbo.Jobs")
            DropTable("dbo.AspNetRoles")
            DropTable("dbo.AspNetUserRoles")
            DropTable("dbo.AspNetUserLogins")
            DropTable("dbo.AspNetUserClaims")
            DropTable("dbo.AspNetUsers")
            DropTable("dbo.Cv")
            DropTable("dbo.Certification")
        End Sub
    End Class
End Namespace
