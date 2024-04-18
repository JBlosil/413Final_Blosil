using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _413Final_Blosil.Models;

public partial class EntertainmentAgencyExampleContext : DbContext
{
    public EntertainmentAgencyExampleContext()
    {
    }

    public EntertainmentAgencyExampleContext(DbContextOptions<EntertainmentAgencyExampleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Agent> Agents { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Engagement> Engagements { get; set; }

    public virtual DbSet<Entertainer> Entertainers { get; set; }

    public virtual DbSet<EntertainerMember> EntertainerMembers { get; set; }

    public virtual DbSet<EntertainerStyle> EntertainerStyles { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<MusicalPreference> MusicalPreferences { get; set; }

    public virtual DbSet<MusicalStyle> MusicalStyles { get; set; }

    public virtual DbSet<ZtblDay> ZtblDays { get; set; }

    public virtual DbSet<ZtblMonth> ZtblMonths { get; set; }

    public virtual DbSet<ZtblSkipLabel> ZtblSkipLabels { get; set; }

    public virtual DbSet<ZtblWeek> ZtblWeeks { get; set; }
}
