﻿using MediatR;
using SmartFinances.Application.Features.Contacts.Requests.Commands;
using SmartFinances.Application.Interfaces.Factories;
using SmartFinances.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFinances.Application.Features.Contacts.Handlers.Commands
{
    public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand>
    {
        private readonly IContactFactory _contactFactory;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteContactCommandHandler(IContactFactory contactFactory, IUnitOfWork unitOfWork)
        {
            _contactFactory = contactFactory;
            _unitOfWork = unitOfWork;
        }
        public async Task Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            var contact = await _unitOfWork.Contacts.GetByIdAsync(request.Id);
            _unitOfWork.Contacts.Delete(contact);
            await _unitOfWork.SaveAsync();

            return;
        }
    }
}
