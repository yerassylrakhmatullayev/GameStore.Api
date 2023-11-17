﻿using GameStore.Api.Entities;

namespace GameStore.Api.Dtos;

public static class EntityExtensions
{
	public static GameDto AsDto(this Game game)
	{
		return new GameDto(
			game.Id,
			game.Name,
			game.Genre,
			game.Price,
			game.ReleaseDate,
			game.ImageUri
			);
	}
}
