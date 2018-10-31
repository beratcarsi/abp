﻿// <auto-generated />
using System;
using IdentityServerHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IdentityServerHost.Migrations
{
    [DbContext(typeof(DemoAppDbContext))]
    partial class DemoAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Volo.Abp.IdentityServer.ApiResources.ApiResource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("DisplayName")
                        .HasMaxLength(200);

                    b.Property<bool>("Enabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("IdentityServerApiResources");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.ApiResources.ApiResourceClaim", b =>
                {
                    b.Property<Guid>("ApiResourceId");

                    b.Property<string>("Type")
                        .HasMaxLength(196);

                    b.HasKey("ApiResourceId", "Type");

                    b.ToTable("IdentityServerApiClaims");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.ApiResources.ApiScope", b =>
                {
                    b.Property<Guid>("ApiResourceId");

                    b.Property<string>("Name")
                        .HasMaxLength(196);

                    b.Property<string>("Description")
                        .HasMaxLength(256);

                    b.Property<string>("DisplayName")
                        .HasMaxLength(128);

                    b.Property<bool>("Emphasize");

                    b.Property<bool>("Required");

                    b.Property<bool>("ShowInDiscoveryDocument");

                    b.HasKey("ApiResourceId", "Name");

                    b.ToTable("IdentityServerApiScopes");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.ApiResources.ApiScopeClaim", b =>
                {
                    b.Property<Guid>("ApiResourceId");

                    b.Property<string>("Name")
                        .HasMaxLength(196);

                    b.Property<string>("Type")
                        .HasMaxLength(196);

                    b.HasKey("ApiResourceId", "Name", "Type");

                    b.ToTable("IdentityServerApiScopeClaims");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.ApiResources.ApiSecret", b =>
                {
                    b.Property<Guid>("ApiResourceId");

                    b.Property<string>("Type")
                        .HasMaxLength(32);

                    b.Property<string>("Value")
                        .HasMaxLength(196);

                    b.Property<string>("Description")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("Expiration");

                    b.HasKey("ApiResourceId", "Type", "Value");

                    b.ToTable("IdentityServerApiSecrets");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AbsoluteRefreshTokenLifetime");

                    b.Property<int>("AccessTokenLifetime");

                    b.Property<int>("AccessTokenType");

                    b.Property<bool>("AllowAccessTokensViaBrowser");

                    b.Property<bool>("AllowOfflineAccess");

                    b.Property<bool>("AllowPlainTextPkce");

                    b.Property<bool>("AllowRememberConsent");

                    b.Property<bool>("AlwaysIncludeUserClaimsInIdToken");

                    b.Property<bool>("AlwaysSendClientClaims");

                    b.Property<int>("AuthorizationCodeLifetime");

                    b.Property<bool>("BackChannelLogoutSessionRequired");

                    b.Property<string>("BackChannelLogoutUri")
                        .HasMaxLength(2000);

                    b.Property<string>("ClientClaimsPrefix")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ClientName")
                        .HasMaxLength(200);

                    b.Property<string>("ClientUri")
                        .HasMaxLength(2000);

                    b.Property<int?>("ConsentLifetime");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<bool>("EnableLocalLogin");

                    b.Property<bool>("Enabled");

                    b.Property<bool>("FrontChannelLogoutSessionRequired");

                    b.Property<string>("FrontChannelLogoutUri")
                        .HasMaxLength(2000);

                    b.Property<int>("IdentityTokenLifetime");

                    b.Property<bool>("IncludeJwtId");

                    b.Property<string>("LogoUri")
                        .HasMaxLength(2000);

                    b.Property<string>("PairWiseSubjectSalt")
                        .HasMaxLength(200);

                    b.Property<string>("ProtocolType")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("RefreshTokenExpiration");

                    b.Property<int>("RefreshTokenUsage");

                    b.Property<bool>("RequireClientSecret");

                    b.Property<bool>("RequireConsent");

                    b.Property<bool>("RequirePkce");

                    b.Property<int>("SlidingRefreshTokenLifetime");

                    b.Property<bool>("UpdateAccessTokenClaimsOnRefresh");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("IdentityServerClients");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ClientId");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("IdentityServerClientClaims");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientCorsOrigin", b =>
                {
                    b.Property<Guid>("ClientId");

                    b.Property<string>("Origin")
                        .HasMaxLength(150);

                    b.HasKey("ClientId", "Origin");

                    b.ToTable("IdentityServerClientCorsOrigins");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientGrantType", b =>
                {
                    b.Property<Guid>("ClientId");

                    b.Property<string>("GrantType")
                        .HasMaxLength(196);

                    b.HasKey("ClientId", "GrantType");

                    b.ToTable("IdentityServerClientGrantTypes");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientIdPRestriction", b =>
                {
                    b.Property<Guid>("ClientId");

                    b.Property<string>("Provider")
                        .HasMaxLength(64);

                    b.HasKey("ClientId", "Provider");

                    b.ToTable("IdentityServerClientIdPRestrictions");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientPostLogoutRedirectUri", b =>
                {
                    b.Property<Guid>("ClientId");

                    b.Property<string>("PostLogoutRedirectUri")
                        .HasMaxLength(2000);

                    b.HasKey("ClientId", "PostLogoutRedirectUri");

                    b.ToTable("IdentityServerClientPostLogoutRedirectUris");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientProperty", b =>
                {
                    b.Property<Guid>("ClientId");

                    b.Property<string>("Key")
                        .HasMaxLength(250);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("ClientId", "Key");

                    b.ToTable("IdentityServerClientProperties");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientRedirectUri", b =>
                {
                    b.Property<Guid>("ClientId");

                    b.Property<string>("RedirectUri")
                        .HasMaxLength(2000);

                    b.HasKey("ClientId", "RedirectUri");

                    b.ToTable("IdentityServerClientRedirectUris");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientScope", b =>
                {
                    b.Property<Guid>("ClientId");

                    b.Property<string>("Scope")
                        .HasMaxLength(196);

                    b.HasKey("ClientId", "Scope");

                    b.ToTable("IdentityServerClientScopes");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientSecret", b =>
                {
                    b.Property<Guid>("ClientId");

                    b.Property<string>("Type")
                        .HasMaxLength(32);

                    b.Property<string>("Value")
                        .HasMaxLength(196);

                    b.Property<string>("Description")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("Expiration");

                    b.HasKey("ClientId", "Type", "Value");

                    b.ToTable("IdentityServerClientSecrets");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Grants.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Data")
                        .IsRequired();

                    b.Property<DateTime?>("Expiration");

                    b.Property<Guid>("Id");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Key");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.ToTable("IdentityServerPersistedGrants");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.IdentityResources.IdentityClaim", b =>
                {
                    b.Property<Guid>("IdentityResourceId");

                    b.Property<string>("Type")
                        .HasMaxLength(196);

                    b.HasKey("IdentityResourceId", "Type");

                    b.ToTable("IdentityServerIdentityClaims");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.IdentityResources.IdentityResource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("DisplayName")
                        .HasMaxLength(200);

                    b.Property<bool>("Emphasize");

                    b.Property<bool>("Enabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("Required");

                    b.Property<bool>("ShowInDiscoveryDocument");

                    b.HasKey("Id");

                    b.ToTable("IdentityServerIdentityResources");
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.ApiResources.ApiResourceClaim", b =>
                {
                    b.HasOne("Volo.Abp.IdentityServer.ApiResources.ApiResource")
                        .WithMany("UserClaims")
                        .HasForeignKey("ApiResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.ApiResources.ApiScope", b =>
                {
                    b.HasOne("Volo.Abp.IdentityServer.ApiResources.ApiResource")
                        .WithMany("Scopes")
                        .HasForeignKey("ApiResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.ApiResources.ApiScopeClaim", b =>
                {
                    b.HasOne("Volo.Abp.IdentityServer.ApiResources.ApiScope")
                        .WithMany("UserClaims")
                        .HasForeignKey("ApiResourceId", "Name")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.ApiResources.ApiSecret", b =>
                {
                    b.HasOne("Volo.Abp.IdentityServer.ApiResources.ApiResource")
                        .WithMany("Secrets")
                        .HasForeignKey("ApiResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientClaim", b =>
                {
                    b.HasOne("Volo.Abp.IdentityServer.Clients.Client")
                        .WithMany("Claims")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientCorsOrigin", b =>
                {
                    b.HasOne("Volo.Abp.IdentityServer.Clients.Client")
                        .WithMany("AllowedCorsOrigins")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientGrantType", b =>
                {
                    b.HasOne("Volo.Abp.IdentityServer.Clients.Client")
                        .WithMany("AllowedGrantTypes")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientIdPRestriction", b =>
                {
                    b.HasOne("Volo.Abp.IdentityServer.Clients.Client")
                        .WithMany("IdentityProviderRestrictions")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientPostLogoutRedirectUri", b =>
                {
                    b.HasOne("Volo.Abp.IdentityServer.Clients.Client")
                        .WithMany("PostLogoutRedirectUris")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientProperty", b =>
                {
                    b.HasOne("Volo.Abp.IdentityServer.Clients.Client")
                        .WithMany("Properties")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientRedirectUri", b =>
                {
                    b.HasOne("Volo.Abp.IdentityServer.Clients.Client")
                        .WithMany("RedirectUris")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientScope", b =>
                {
                    b.HasOne("Volo.Abp.IdentityServer.Clients.Client")
                        .WithMany("AllowedScopes")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.Clients.ClientSecret", b =>
                {
                    b.HasOne("Volo.Abp.IdentityServer.Clients.Client")
                        .WithMany("ClientSecrets")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volo.Abp.IdentityServer.IdentityResources.IdentityClaim", b =>
                {
                    b.HasOne("Volo.Abp.IdentityServer.IdentityResources.IdentityResource")
                        .WithMany("UserClaims")
                        .HasForeignKey("IdentityResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}