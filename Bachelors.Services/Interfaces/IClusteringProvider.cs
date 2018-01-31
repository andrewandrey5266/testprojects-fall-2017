using System.Collections.Generic;
using Bachelors.Domain.Models;

namespace Bachelors.Services.Interfaces
{
	public interface IClusteringProvider
	{
		List<Team> FormDiverseTeam(List<TestResult> testResults);
	}
}