using System.Collections.Generic;

namespace Bachelors.Domain.Models
{
	public class MetricBundle
	{
		public IReadOnlyList<Metric> Metrics { get; set; }
	}
}