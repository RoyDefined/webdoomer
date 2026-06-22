
namespace WebDoomerApi.Scheduling;

public interface IScheduler
{
	internal void Tick(CancellationToken cancellationToken);

	/// <summary>
	/// Adds the given schedule to the list of tasks to invoke on a schedule.
	/// </summary>
	/// <param name="scheduledEvent">The scheduled event to add.</param>
	void AddSchedule(ScheduledEvent scheduledEvent);
}