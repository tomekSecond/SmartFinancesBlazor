﻿using SmartFinances.Application.Features.Accounts.Dtos;
using SmartFinances.Core.Enums;

namespace SmartFinances.Application.Features.RegularExpenses.Dtos
{
    public class RegularExpenseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public ExpenseType Type { get; set; }
        public int AccountId { get; set; }
        public AccountDto Account { get; set; }
    }
}
