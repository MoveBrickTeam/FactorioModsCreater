require "util"
require "story"
require "defines"
require "transportbeltmadness"

levels=
{
  {
    starting_location = {0, 4},
    area = {{-16, -9}, {16, 9}},
    level_width = 30,
    description = "level-03",
    recipes = { "iron-gear-wheel", "basic-transport-belt", "basic-transport-belt-to-ground"},
    ["resources"] =
    {
      {
        name="iron-plate",
        count=700
      }
    },
    ["chests"]=
    {
      {
        item="iron-plate",
        input=1,
        output=5
      },
      {
        item="copper-plate",
        input=2,
        output=7
      },
      {
        item="iron-gear-wheel",
        input=3,
        output=6
      },
      {
        item="steel-plate",
        input=5,
        output=1
      },
      {
        item="coal",
        input=6,
        output=3
      },
      {
        item="electronic-circuit",
        input=7,
        output=2
      }
    }
  },
  {
    starting_location = {0, 4},
    area = {{-16, -9}, {16, 9}},
    description = "level-04",
    level_width = 30,
    recipes =
    {
      "iron-gear-wheel",
      "basic-transport-belt",
      "basic-transport-belt-to-ground",
      "fast-transport-belt",
      "fast-transport-belt-to-ground"
    },
    ["resources"] =
    {
      {
        name="iron-plate",
        count=2200
      }
    },
    ["chests"]=
    {
      {
        item="iron-plate",
        input=1,
        output=9
      },
      {
        item="copper-plate",
        input=2,
        output=7
      },
      {
        item="iron-gear-wheel",
        input=3,
        output=6
      },
      {
        item="steel-plate",
        input=4,
        output=8
      },
      {
        item="coal",
        input=6,
        output=3
      },
      {
        item="electronic-circuit",
        input=7,
        output=2
      },
      {
        item="wood",
        input=8,
        output=4
      },
      {
        item="copper-ore",
        input=9,
        output=1
      }
    }
  }
}

script.on_init(function()
  global.story = story_init(story_table)
  global.transport_belt_madness = transport_belt_madness_init(levels)
  game.always_day = true
  game.player.force.disable_research()
end)

script.on_event(defines.events, function(event)
  story_update(global.story, event, "level-03")
end)

