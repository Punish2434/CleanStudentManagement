﻿using System;
using CleanStudentManagement.Data.Entities;

namespace CleanStudentManagement.Models
{
    public class GroupViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public GroupViewModel()
        {

        }

        public GroupViewModel(Groups group)
        {
            Id = group.Id;
            Name = group.Name;
            Description = group.Description;

        }

        public Groups ConverttoGroup(GroupViewModel groupViewModel)
        {
            return new Groups
            {
                Id = groupViewModel.Id,
                Name = groupViewModel.Name,
                Description = groupViewModel.Description
            };
        }

    }
}

