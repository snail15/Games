#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.GameObject[]
struct GameObjectU5BU5D_t3057952154;
// UnityEngine.GameObject
struct GameObject_t1756533147;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ShapeSpawner
struct  ShapeSpawner_t498142553  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject[] ShapeSpawner::shapes
	GameObjectU5BU5D_t3057952154* ___shapes_2;
	// UnityEngine.GameObject[] ShapeSpawner::next
	GameObjectU5BU5D_t3057952154* ___next_4;
	// UnityEngine.GameObject ShapeSpawner::nextShape
	GameObject_t1756533147 * ___nextShape_5;
	// System.Int32 ShapeSpawner::nextIdx
	int32_t ___nextIdx_6;

public:
	inline static int32_t get_offset_of_shapes_2() { return static_cast<int32_t>(offsetof(ShapeSpawner_t498142553, ___shapes_2)); }
	inline GameObjectU5BU5D_t3057952154* get_shapes_2() const { return ___shapes_2; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_shapes_2() { return &___shapes_2; }
	inline void set_shapes_2(GameObjectU5BU5D_t3057952154* value)
	{
		___shapes_2 = value;
		Il2CppCodeGenWriteBarrier(&___shapes_2, value);
	}

	inline static int32_t get_offset_of_next_4() { return static_cast<int32_t>(offsetof(ShapeSpawner_t498142553, ___next_4)); }
	inline GameObjectU5BU5D_t3057952154* get_next_4() const { return ___next_4; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_next_4() { return &___next_4; }
	inline void set_next_4(GameObjectU5BU5D_t3057952154* value)
	{
		___next_4 = value;
		Il2CppCodeGenWriteBarrier(&___next_4, value);
	}

	inline static int32_t get_offset_of_nextShape_5() { return static_cast<int32_t>(offsetof(ShapeSpawner_t498142553, ___nextShape_5)); }
	inline GameObject_t1756533147 * get_nextShape_5() const { return ___nextShape_5; }
	inline GameObject_t1756533147 ** get_address_of_nextShape_5() { return &___nextShape_5; }
	inline void set_nextShape_5(GameObject_t1756533147 * value)
	{
		___nextShape_5 = value;
		Il2CppCodeGenWriteBarrier(&___nextShape_5, value);
	}

	inline static int32_t get_offset_of_nextIdx_6() { return static_cast<int32_t>(offsetof(ShapeSpawner_t498142553, ___nextIdx_6)); }
	inline int32_t get_nextIdx_6() const { return ___nextIdx_6; }
	inline int32_t* get_address_of_nextIdx_6() { return &___nextIdx_6; }
	inline void set_nextIdx_6(int32_t value)
	{
		___nextIdx_6 = value;
	}
};

struct ShapeSpawner_t498142553_StaticFields
{
public:
	// System.Int32 ShapeSpawner::idx
	int32_t ___idx_3;

public:
	inline static int32_t get_offset_of_idx_3() { return static_cast<int32_t>(offsetof(ShapeSpawner_t498142553_StaticFields, ___idx_3)); }
	inline int32_t get_idx_3() const { return ___idx_3; }
	inline int32_t* get_address_of_idx_3() { return &___idx_3; }
	inline void set_idx_3(int32_t value)
	{
		___idx_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
