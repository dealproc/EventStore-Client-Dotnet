using System;

#nullable enable
namespace EventStore.Client {
	public class EventStoreClientOperationOptions {
		public TimeSpan? TimeoutAfter { get; set; }
		public bool ThrowOnFailure { get; set; }

		public static EventStoreClientOperationOptions Default => new EventStoreClientOperationOptions {
			TimeoutAfter = TimeSpan.FromSeconds(5),
			ThrowOnFailure = true
		};

		public EventStoreClientOperationOptions Clone() =>
			new EventStoreClientOperationOptions {
				TimeoutAfter = TimeoutAfter,
				ThrowOnFailure = true
			};
	}
}
