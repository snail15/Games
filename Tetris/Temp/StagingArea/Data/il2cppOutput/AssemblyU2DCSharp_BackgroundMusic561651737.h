#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.AudioClip
struct AudioClip_t1932558630;
// BackgroundMusic
struct BackgroundMusic_t561651737;
// UnityEngine.AudioSource
struct AudioSource_t1135106623;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// BackgroundMusic
struct  BackgroundMusic_t561651737  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.AudioClip BackgroundMusic::gameMusic
	AudioClip_t1932558630 * ___gameMusic_2;
	// UnityEngine.AudioSource BackgroundMusic::music
	AudioSource_t1135106623 * ___music_4;

public:
	inline static int32_t get_offset_of_gameMusic_2() { return static_cast<int32_t>(offsetof(BackgroundMusic_t561651737, ___gameMusic_2)); }
	inline AudioClip_t1932558630 * get_gameMusic_2() const { return ___gameMusic_2; }
	inline AudioClip_t1932558630 ** get_address_of_gameMusic_2() { return &___gameMusic_2; }
	inline void set_gameMusic_2(AudioClip_t1932558630 * value)
	{
		___gameMusic_2 = value;
		Il2CppCodeGenWriteBarrier(&___gameMusic_2, value);
	}

	inline static int32_t get_offset_of_music_4() { return static_cast<int32_t>(offsetof(BackgroundMusic_t561651737, ___music_4)); }
	inline AudioSource_t1135106623 * get_music_4() const { return ___music_4; }
	inline AudioSource_t1135106623 ** get_address_of_music_4() { return &___music_4; }
	inline void set_music_4(AudioSource_t1135106623 * value)
	{
		___music_4 = value;
		Il2CppCodeGenWriteBarrier(&___music_4, value);
	}
};

struct BackgroundMusic_t561651737_StaticFields
{
public:
	// BackgroundMusic BackgroundMusic::instance
	BackgroundMusic_t561651737 * ___instance_3;

public:
	inline static int32_t get_offset_of_instance_3() { return static_cast<int32_t>(offsetof(BackgroundMusic_t561651737_StaticFields, ___instance_3)); }
	inline BackgroundMusic_t561651737 * get_instance_3() const { return ___instance_3; }
	inline BackgroundMusic_t561651737 ** get_address_of_instance_3() { return &___instance_3; }
	inline void set_instance_3(BackgroundMusic_t561651737 * value)
	{
		___instance_3 = value;
		Il2CppCodeGenWriteBarrier(&___instance_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
