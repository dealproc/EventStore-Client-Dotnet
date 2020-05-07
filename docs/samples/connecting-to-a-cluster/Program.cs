﻿using System;
using System.Net;
using EventStore.Client;

namespace connecting_to_a_cluster {
	class Program {
		static void Main(string[] args) {
		}
		
		private static void ConnectingToACluster() {
			//connecting-to-a-cluster
			var settings = new EventStoreClientSettings {
				ConnectivitySettings =
				{
					DnsGossipSeeds = new[]
					{
						new DnsEndPoint("localhost", 1114),
						new DnsEndPoint("localhost", 2114),
						new DnsEndPoint("localhost", 3114),
					}
				}
			};

			var connection = new EventStoreClient(settings);
			//connecting-to-a-cluster
		}
		
		private static void ConnectingToAClusterComplex() {
			//connecting-to-a-cluster-complex
			var settings = new EventStoreClientSettings {
				ConnectivitySettings =
				{
					DnsGossipSeeds = new[]
					{
						new DnsEndPoint("localhost", 1114),
						new DnsEndPoint("localhost", 2114),
						new DnsEndPoint("localhost", 3114),
					},
					DiscoveryInterval = TimeSpan.FromMilliseconds(30),
					GossipTimeout = TimeSpan.FromSeconds(10),
					NodePreference = NodePreference.Leader,
					MaxDiscoverAttempts = 5
				}
			};

			var connection = new EventStoreClient(settings);
			//connecting-to-a-cluster-complex
		}
	}
}
