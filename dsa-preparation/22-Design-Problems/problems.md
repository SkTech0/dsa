# Design Problems — LLD Style

Low-Level Design problems commonly asked at product companies.

---

## Must-Do

### LRU Cache
- **Link:** https://leetcode.com/problems/lru-cache/
- **Difficulty:** Medium
- **Core Pattern:** HashMap + Doubly Linked List
- **Key Points:** O(1) get/put, evict least recently used

### Design Parking Lot
- **Source:** System Design / LLD
- **Difficulty:** Medium
- **Core Pattern:** OOP, State management
- **Key Points:** Vehicle types, slot assignment, fee calculation

### Rate Limiter
- **Source:** System Design / LLD
- **Difficulty:** Medium
- **Core Pattern:** Sliding window / Token bucket
- **Key Points:** Requests per time window, distributed consideration

### Logger
- **Link:** https://leetcode.com/problems/logger-rate-limiter/
- **Difficulty:** Easy
- **Core Pattern:** HashMap for last timestamp
- **Key Points:** Same message within 10 seconds → false

### Elevator System
- **Source:** System Design / LLD
- **Difficulty:** Hard
- **Core Pattern:** State machine, Request queue
- **Key Points:** Direction, floor requests, load balancing

### Design HashMap (Custom)
- **Link:** https://leetcode.com/problems/design-hashmap/
- **Difficulty:** Easy
- **Core Pattern:** Array + Chaining / Open addressing

### Design Min Stack
- **Link:** https://leetcode.com/problems/min-stack/
- **Difficulty:** Medium
- **Core Pattern:** Stack + auxiliary structure for min
