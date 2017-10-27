#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// SoundManager
struct SoundManager_t654432262;
// UnityEngine.AudioClip
struct AudioClip_t1932558630;
// UnityEngine.AudioSource
struct AudioSource_t1135106623;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// SoundManager
struct  SoundManager_t654432262  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.AudioClip SoundManager::gameOver
	AudioClip_t1932558630 * ___gameOver_3;
	// UnityEngine.AudioClip SoundManager::rowDelete
	AudioClip_t1932558630 * ___rowDelete_4;
	// UnityEngine.AudioClip SoundManager::shapeStop
	AudioClip_t1932558630 * ___shapeStop_5;
	// UnityEngine.AudioSource SoundManager::music
	AudioSource_t1135106623 * ___music_6;

public:
	inline static int32_t get_offset_of_gameOver_3() { return static_cast<int32_t>(offsetof(SoundManager_t654432262, ___gameOver_3)); }
	inline AudioClip_t1932558630 * get_gameOver_3() const { return ___gameOver_3; }
	inline AudioClip_t1932558630 ** get_address_of_gameOver_3() { return &___gameOver_3; }
	inline void set_gameOver_3(AudioClip_t1932558630 * value)
	{
		___gameOver_3 = value;
		Il2CppCodeGenWriteBarrier(&___gameOver_3, value);
	}

	inline static int32_t get_offset_of_rowDelete_4() { return static_cast<int32_t>(offsetof(SoundManager_t654432262, ___rowDelete_4)); }
	inline AudioClip_t1932558630 * get_rowDelete_4() const { return ___rowDelete_4; }
	inline AudioClip_t1932558630 ** get_address_of_rowDelete_4() { return &___rowDelete_4; }
	inline void set_rowDelete_4(AudioClip_t1932558630 * value)
	{
		___rowDelete_4 = value;
		Il2CppCodeGenWriteBarrier(&___rowDelete_4, value);
	}

	inline static int32_t get_offset_of_shapeStop_5() { return static_cast<int32_t>(offsetof(SoundManager_t654432262, ___shapeStop_5)); }
	inline AudioClip_t1932558630 * get_shapeStop_5() const { return ___shapeStop_5; }
	inline AudioClip_t1932558630 ** get_address_of_shapeStop_5() { return &___shapeStop_5; }
	inline void set_shapeStop_5(AudioClip_t1932558630 * value)
	{
		___shapeStop_5 = value;
		Il2CppCodeGenWriteBarrier(&___shapeStop_5, value);
	}

	inline static int32_t get_offset_of_music_6() { return static_cast<int32_t>(offsetof(SoundManager_t654432262, ___music_6)); }
	inline AudioSource_t1135106623 * get_music_6() const { return ___music_6; }
	inline AudioSource_t1135106623 ** get_address_of_music_6() { return &___music_6; }
	inline void set_music_6(AudioSource_t1135106623 * value)
	{
		___music_6 = value;
		Il2CppCodeGenWriteBarrier(&___music_6, value);
	}
};

struct SoundManager_t654432262_StaticFields
{
public:
	// SoundManager SoundManager::instance
	SoundManager_t654432262 * ___instance_2;

public:
	inline static int32_t get_offset_of_instance_2() { return static_cast<int32_t>(offsetof(SoundManager_t654432262_StaticFields, ___instance_2)); }
	inline SoundManager_t654432262 * get_instance_2() const { return ___instance_2; }
	inline SoundManager_t654432262 ** get_address_of_instance_2() { return &___instance_2; }
	inline void set_instance_2(SoundManager_t654432262 * value)
	{
		___instance_2 = value;
		Il2CppCodeGenWriteBarrier(&___instance_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
