﻿ 
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ViewModels.MessageChatViewModel;
 
    public class UserDto
    {
    }
    public class UserForAddDto  
    {
        [Required]
        [StringLength(50, ErrorMessage = "Username cannot be longer then 50 characters")]
        public string Username { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Email cannot be longer then 50 characters")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(15)]
        public string ContactNumber { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "FullName cannot be longer then 50 characters")]
        public string FullName { get; set; }
        //public string OldPassword { get; set; }
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }
        //[Required]
 
        public string DateofBirth { get; set; }

        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public int? CountryId { get; set; }
        public string OtherState { get; set; }
        //[Required]
        //[StringLength(50, ErrorMessage = "City cannot be longer then 50 characters")]
        //public string City { get; set; }

        //[Required]
        //[StringLength(50, ErrorMessage = "Country cannot be longer then 50 characters")]
        //public string Country { get; set; }
        [Required]
        public int UserTypeId { get; set; } //= 2;

        //[Required]
        //[StringLength(50, ErrorMessage = "Roll Number cannot be longer then 50 characters")]
        public string RegistrationNumber { get; set; }
        //public bool HasRegNumber { get; set; }
        [StringLength(15)]
        public string ParentCNIC { get; set; }
        public string ParentEmail { get; set; }
        public string ParentContactNumber { get; set; }
        //[Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        //[RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid integer Number")]
        public string LevelFrom { get; set; }
        //[RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid integer Number")]
        public string LevelTo { get; set; }
        public List<string> Experties { get; set; }
        //public bool Active { get; set; }

    }
    public class UserForUpdateDto 
    {
        [Required]
        [StringLength(50, ErrorMessage = "Username cannot be longer then 50 characters")]
        public string Username { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Email cannot be longer then 50 characters")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(15)]
        public string ContactNumber { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "FullName cannot be longer then 50 characters")]
        public string FullName { get; set; }
        public string OldPassword { get; set; }
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }
        //[Required]
         
        public string DateofBirth { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public int? CountryId { get; set; }
        public string OtherState { get; set; }
        //[Required]
        //[StringLength(50, ErrorMessage = "City cannot be longer then 50 characters")]
        //public string City { get; set; }

        //[Required]
        //[StringLength(50, ErrorMessage = "Country cannot be longer then 50 characters")]
        //public string Country { get; set; }

        public bool IsPrimaryPhoto { get; set; } = true;
        public int UserTypeId { get; set; }
        public bool Active { get; set; } = true;
        //public string RollNumber { get; set; }
        [StringLength(15)]
        public string ParentCNIC { get; set; }
        public string ParentEmail { get; set; }
        public string ParentContactNumber { get; set; }
        public string LevelFrom { get; set; }
        public string LevelTo { get; set; }
        public string LevelFromName { get; set; }
        public string LevelToName { get; set; }
        public List<string> Experties { get; set; }
        public IFormFileCollection files { get; set; }
    }
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        //public string Password { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string DateofBirth { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public int? CountryId { get; set; }
        public string StateName { get; set; }
        public string CountryName { get; set; }
        public string OtherState { get; set; }
        public int UserTypeId { get; set; }
        public string UserType { get; set; }
        public string RegistrationNumber { get; set; }
        public bool Active { get; set; } = true;
        public string MemberSince { get; set; }
        public string ParentCNIC { get; set; }
        public string ParentEmail { get; set; }
        public string ParentContactNumber { get; set; }
        public int LevelFrom { get; set; }
        public int LevelTo { get; set; }
 
        public List<PhotoDto> Photos { get; set; }
    }
    public class UserForListDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        //public string Password { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string DateofBirth { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public int? CountryId { get; set; }
        public string StateName { get; set; }
        public string CountryName { get; set; }
        public string OtherState { get; set; }
        public int UserTypeId { get; set; }
        public string UserType { get; set; }
        public string RegistrationNumber { get; set; }
        public bool Active { get; set; } = true;
        public List<PhotoDto> Photos { get; set; }
    }

    public class UserByTypeListDto
    {
        public int ClassSectionId { get; set; }
        public int SubjectId { get; set; }
        public int UserTypeId { get; set; }
        public string FullName { get; set; }
        public int UserId { get; set; }
        public bool Present { get; set; }
        public bool Absent { get; set; }
        public bool Late { get; set; }
        public string Comments { get; set; }
        public bool Leave { get; set; }
        public string LeaveComments { get; set; }
        public string CreatedDatetime { get; set; }
        public int LateCount { get; set; }
        public int AbsentCount { get; set; }
        public int LeaveCount { get; set; }
        public int PresentCount { get; set; }
        public List<PhotoDto> Photos { get; set; }
    }
    public class UserForLoginDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public int SchoolName1 { get; set; } = 0;
    }
    public class ForgotPasswordDto
    {
        public string Email { get; set; }
    }
    public class ResetPasswordDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class UserForRegisterDto
    {
        public string SchoolName { get; set; }
        public string ExamType { get; set; }
        [Required]
        public string Username { get; set; }
        public string FullName { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 8 characters")]
        public string Password { get; set; }
        public string Gender { get; set; } = "male";

        [EmailAddress]
        public string Email { get; set; }
        [StringLength(15)]
        public string ContactNumber { get; set; }
        public int UserTypeId { get; set; } = 1;
        public string UserTypeSignUp { get; set; }
        public List<IFormFile> files { get; set; }
    }

    public class UserForAddInGroupDto
    {       
        public int? Id { get; set; }
        public int ClassSectionId { get; set; }
        public string GroupName { get; set; }
        public List<int> UserIds { get; set; } = new List<int>();
        public bool? Active { get; set; } = true;
    }
    public class GroupUserListDto
    {
        public int Value { get; set; }
        public string Display { get; set; }
    }
    public class GroupListDto
    {       
        public int Id { get; set; }
        public string GroupName { get; set; }
        public List<GroupUserListDto> Children { get; set; } = new List<GroupUserListDto>();
    }
    public class GroupUserListForEditDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }
    public class GroupListForEditDto
    {        
        public int Id { get; set; }
        public string GroupName { get; set; }
        public int ClassSectionId { get; set; }
        public List<GroupUserListForEditDto> Students { get; set; } = new List<GroupUserListForEditDto>();
    }
    
   
    public class UnMapUserForAddDto
    {
        public int Id { get; set; }
        public int ClassSectionId { get; set; }
        public int UserId { get; set; }

    }
    public class PhotoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDatetime { get; set; }
        public bool IsPrimary { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }

    }
    public class GetByIdFlagDto
    {
        public int Id { get; set; }
        public bool IsEditable { get; set; }
    }

    public class ExStudentForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        public string FullName { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 8 characters")]
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(15)]
        public string ContactNumber { get; set; }      
        public int TutorId { get; set; }      
        public int SubjectId { get; set; }      
        public List<IFormFile> files { get; set; }
    }
    public class ExStudentForLoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }        
        public int TutorId { get; set; } = 0;
        public int SubjectId { get; set; } = 0;
    }
 
