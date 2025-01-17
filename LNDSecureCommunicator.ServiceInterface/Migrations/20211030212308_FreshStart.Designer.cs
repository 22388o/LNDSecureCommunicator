﻿// <auto-generated />
using System;
using LNDSecureCommunicator.ServiceInterface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LNDSecureCommunicator.ServiceInterface.Migrations
{
    [DbContext(typeof(LNDSecureContext))]
    [Migration("20211030212308_FreshStart")]
    partial class FreshStart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("LNDSecureCommunicator.ServiceInterface.DecodedMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("FileData")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NodePubkey")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CreatedDate");

                    b.HasIndex("NodePubkey");

                    b.ToTable("DecodedMessages");
                });

            modelBuilder.Entity("LNDSecureCommunicator.ServiceInterface.LNDSecureCommunicatorSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientAuthBase32PublicKey")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientAuthBase64PrivateKey")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("InvoiceLastIndexOffset")
                        .HasColumnType("INTEGER");

                    b.Property<string>("KeyType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NodePubkey")
                        .HasColumnType("TEXT");

                    b.Property<string>("OnionPrivateKeyBase32")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OnionPublicAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("LNDSecureCommunicatorSettings");
                });

            modelBuilder.Entity("LNDSecureCommunicator.ServiceInterface.RemoteNode", b =>
                {
                    b.Property<string>("NodePubkey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientAuthBase32PublicKey")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Disabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OnionAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("RemoteNodeACK")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SharedBase64PrivateKey")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("NodePubkey");

                    b.HasIndex("Disabled");

                    b.ToTable("RemoteNodes");
                });
#pragma warning restore 612, 618
        }
    }
}
