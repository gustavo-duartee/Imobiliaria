﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Imobiliaria.model
{
    public partial class IMOBILIARIAContext : DbContext
    {
        public IMOBILIARIAContext()
        {
        }

        public IMOBILIARIAContext(DbContextOptions<IMOBILIARIAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agendar> Agendar { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Corretor> Corretor { get; set; }
        public virtual DbSet<Imoveis> Imoveis { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-M210FP2\\SQLEXPRESS;Initial Catalog=IMOBILIARIA;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agendar>(entity =>
            {
                entity.HasKey(e => e.CdAgendar)
                    .HasName("PK__Agendar__DB48D0621FA04726");

                entity.Property(e => e.CdAgendar).HasColumnName("cd_Agendar");

                entity.Property(e => e.CdCliente)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cd_cliente")
                    .IsFixedLength();

                entity.Property(e => e.CdCorretor)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cd_corretor")
                    .IsFixedLength();

                entity.Property(e => e.CdImovel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cd_imovel")
                    .IsFixedLength();

                entity.Property(e => e.DataAgendada)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("data_agendada")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.CdCliente)
                    .HasName("PK__Cliente__9A275542E99A5CDE");

                entity.Property(e => e.CdCliente).HasColumnName("cd_Cliente");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF")
                    .IsFixedLength();

                entity.Property(e => e.DataNascimento)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("data_nascimento")
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.NmCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nm_cliente");

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("telefone")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Corretor>(entity =>
            {
                entity.HasKey(e => e.CdCorretor)
                    .HasName("PK__Corretor__26446DBFB3015496");

                entity.Property(e => e.CdCorretor).HasColumnName("cd_Corretor");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF")
                    .IsFixedLength();

                entity.Property(e => e.DataNascimento)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("data_nascimento")
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.NmCorretor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nm_corretor");

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("telefone")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Imoveis>(entity =>
            {
                entity.HasKey(e => e.CdImovel)
                    .HasName("PK__Imoveis__54ED318DF3DED6E3");

                entity.Property(e => e.CdImovel).HasColumnName("cd_Imovel");

                entity.Property(e => e.Andares)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Banheiros)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CEP")
                    .IsFixedLength();

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Endereço)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Garagem)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lavanderia)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Quartos)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tamanho)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.CdReserva)
                    .HasName("PK__Reserva__725A4758C7511A6F");

                entity.Property(e => e.CdReserva).HasColumnName("cd_Reserva");

                entity.Property(e => e.CdCliente)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cd_cliente")
                    .IsFixedLength();

                entity.Property(e => e.CdCorretor)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cd_corretor")
                    .IsFixedLength();

                entity.Property(e => e.CdImovel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cd_imovel")
                    .IsFixedLength();

                entity.Property(e => e.Valor)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("valor")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}