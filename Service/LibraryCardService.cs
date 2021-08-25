﻿using System.Collections.Generic;
using System.Linq;
using LMSystem.Data;
using LMSystem.Data.Models;

namespace LMSystem.Service
{
    public class LibraryCardService : ILibraryCardService
    {
        private readonly LibraryDbContext _context;

        public LibraryCardService(LibraryDbContext context)
        {
            _context = context;
        }

        public void Add(LibraryCard newLibraryCard)
        {
            _context.Add(newLibraryCard);
            _context.SaveChanges();
        }

        public LibraryCard Get(int cardId)
        {
            return _context.LibraryCards.FirstOrDefault(p => p.Id == cardId);
        }

        public IEnumerable<LibraryCard> GetAll()
        {
            return _context.LibraryCards;
        }
    }
}