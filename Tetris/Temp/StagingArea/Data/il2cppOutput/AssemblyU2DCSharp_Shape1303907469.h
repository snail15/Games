#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"





#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Shape
struct  Shape_t1303907469  : public MonoBehaviour_t1158329972
{
public:
	// System.Single Shape::lastMoveDown
	float ___lastMoveDown_4;

public:
	inline static int32_t get_offset_of_lastMoveDown_4() { return static_cast<int32_t>(offsetof(Shape_t1303907469, ___lastMoveDown_4)); }
	inline float get_lastMoveDown_4() const { return ___lastMoveDown_4; }
	inline float* get_address_of_lastMoveDown_4() { return &___lastMoveDown_4; }
	inline void set_lastMoveDown_4(float value)
	{
		___lastMoveDown_4 = value;
	}
};

struct Shape_t1303907469_StaticFields
{
public:
	// System.Single Shape::speed
	float ___speed_2;
	// System.Int32 Shape::score
	int32_t ___score_3;

public:
	inline static int32_t get_offset_of_speed_2() { return static_cast<int32_t>(offsetof(Shape_t1303907469_StaticFields, ___speed_2)); }
	inline float get_speed_2() const { return ___speed_2; }
	inline float* get_address_of_speed_2() { return &___speed_2; }
	inline void set_speed_2(float value)
	{
		___speed_2 = value;
	}

	inline static int32_t get_offset_of_score_3() { return static_cast<int32_t>(offsetof(Shape_t1303907469_StaticFields, ___score_3)); }
	inline int32_t get_score_3() const { return ___score_3; }
	inline int32_t* get_address_of_score_3() { return &___score_3; }
	inline void set_score_3(int32_t value)
	{
		___score_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
