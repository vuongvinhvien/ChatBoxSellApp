namespace ChatBoxSellApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId });
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId });
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        ID_Customer = c.String(maxLength: 128),
                        Avartar = c.String(maxLength: 256),
                        IsMain = c.Boolean(),
                        status = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.chatagent2",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ip = c.String(maxLength: 255, unicode: false),
                        addweb = c.String(maxLength: 255, unicode: false),
                        idchat = c.String(maxLength: 255, unicode: false),
                        urlchat = c.String(maxLength: 255, unicode: false),
                        name = c.String(maxLength: 255),
                        email = c.String(maxLength: 255),
                        sdt = c.String(maxLength: 255, unicode: false),
                        value1 = c.String(maxLength: 255, unicode: false),
                        value2 = c.String(maxLength: 255, unicode: false),
                        value3 = c.String(maxLength: 255, unicode: false),
                        value4 = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.chatclient",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ip = c.String(maxLength: 255, unicode: false),
                        addweb = c.String(maxLength: 255, unicode: false),
                        idchat = c.String(maxLength: 255, unicode: false),
                        urlchat = c.String(maxLength: 255, unicode: false),
                        name = c.String(maxLength: 255),
                        email = c.String(maxLength: 255, unicode: false),
                        sdt = c.String(maxLength: 255, unicode: false),
                        value1 = c.String(maxLength: 255, unicode: false),
                        value2 = c.String(maxLength: 255, unicode: false),
                        value3 = c.String(maxLength: 255, unicode: false),
                        value4 = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ChatLine",
                c => new
                    {
                        ID_ContentChat = c.Int(nullable: false, identity: true),
                        Visitor = c.String(maxLength: 128),
                        Agent = c.String(maxLength: 128),
                        feeling = c.Boolean(),
                        Comment = c.String(),
                        Address = c.String(),
                        ID_Customer = c.String(maxLength: 128),
                        Line = c.String(),
                        Date = c.DateTime(),
                        Actor = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID_ContentChat);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        ID_Customer = c.String(nullable: false, maxLength: 128),
                        DateCreate = c.DateTime(),
                        MaSoThue = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID_Customer);
            
            CreateTable(
                "dbo.Setting",
                c => new
                    {
                        ID_Setting = c.String(nullable: false, maxLength: 128),
                        ID_Customer = c.String(maxLength: 128),
                        EmailSendScript = c.String(maxLength: 256),
                        Sound = c.Boolean(),
                        ShareFileAgent = c.Boolean(),
                        ShareFileVisitor = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID_Setting);
            
            CreateTable(
                "dbo.Visitor",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        User_name = c.String(maxLength: 50, fixedLength: true),
                        google = c.String(maxLength: 10, fixedLength: true),
                        facebook = c.String(maxLength: 10, fixedLength: true),
                        email = c.String(maxLength: 256),
                        Phone = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Visitor");
            DropTable("dbo.Setting");
            DropTable("dbo.Customer");
            DropTable("dbo.ChatLine");
            DropTable("dbo.chatclient");
            DropTable("dbo.chatagent2");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetRoles");
        }
    }
}
