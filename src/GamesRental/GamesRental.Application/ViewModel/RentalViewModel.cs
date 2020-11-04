﻿using System;

namespace GamesRental.Application.ViewModel
{
    public class RentalViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public DateTime? DateEstimated { get; set; }

        public DateTime? DateFinish { get; set; }

        public int IdFriend { get; set; }

        public string  FriendName { get; set; }

        public int IdGame { get; set; }

        public string GameName { get; set; }

        public string Status { get; set; }

        public RentalViewModel(int _idGame, int _idFriend, DateTime _date)
        {
            this.IdGame = _idGame;
            this.IdFriend = _idFriend;
            this.Date = _date;
        }
    }

    public class RentalCreateViewModel
    {
        public int IdGame { get; set; }

        public int IdFriend { get; set; }
    }
}
